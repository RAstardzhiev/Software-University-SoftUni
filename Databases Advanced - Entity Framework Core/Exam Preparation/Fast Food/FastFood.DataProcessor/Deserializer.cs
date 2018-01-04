using FastFood.Data;
using FastFood.DataProcessor.Dto.Import;
using FastFood.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FastFood.DataProcessor
{
    public static class Deserializer
    {
        private const string FailureMessage = "Invalid data format.";
        private const string SuccessMessage = "Record {0} successfully imported.";
        private const string OrderSuccessMessage = "Order for {0} on {1} added";
        private const string DateFormat = "dd/MM/yyyy HH:mm";

        public static string ImportEmployees(FastFoodDbContext context, string jsonString)
        {
            var deserializedEmployees = JsonConvert.DeserializeObject<EmployeeDto[]>(jsonString);

            var sb = new StringBuilder();

            var validEmployees = new List<Employee>();
            var positions = new HashSet<Position>();
            foreach (var employeeDto in deserializedEmployees)
            {
                if (!IsValid(employeeDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var position = positions
                    .FirstOrDefault(p => p.Name.Equals(employeeDto.PositionName, StringComparison.OrdinalIgnoreCase));
                if (position == null)
                {
                    position = new Position { Name = employeeDto.PositionName };

                    positions.Add(position);
                }

                var readyEmployee = new Employee
                {
                    Name = employeeDto.Name,
                    Age = employeeDto.Age,
                    Position = position
                };

                sb.AppendLine(string.Format(SuccessMessage, readyEmployee.Name));

                validEmployees.Add(readyEmployee);
            }

            context.Employees.AddRange(validEmployees);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportItems(FastFoodDbContext context, string jsonString)
        {
            var deserializedItems = JsonConvert.DeserializeObject<ItemDto[]>(jsonString);

            var sb = new StringBuilder();

            var validItems = new HashSet<Item>();
            var categories = new HashSet<Category>();
            foreach (var itemDto in deserializedItems)
            {
                if (!IsValid(itemDto) ||
                    validItems.Any(i => i.Name.Equals(itemDto.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var category = categories
                    .FirstOrDefault(c => c.Name.Equals(itemDto.CategoryName, StringComparison.OrdinalIgnoreCase));
                if (category == null)
                {
                    category = new Category { Name = itemDto.CategoryName };

                    categories.Add(category);
                }

                var readyItem = new Item
                {
                    Name = itemDto.Name,
                    Price = itemDto.Price,
                    Category = category
                };

                sb.AppendLine(string.Format(SuccessMessage, readyItem.Name));

                validItems.Add(readyItem);
            }

            context.Items.AddRange(validItems);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportOrders(FastFoodDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(OrderDto[]), new XmlRootAttribute("Orders"));
            var deserializedOrders = (OrderDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var sb = new StringBuilder();

            var validOrders = new List<Order>();

            foreach (var orderDto in deserializedOrders)
            {
                if (!IsValid(orderDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var areAllItemsValid = true;
                var orderItems = new List<OrderItem>();
                foreach (var oi in orderDto.Items)
                {
                    var item = context.Items
                        .FirstOrDefault(i => i.Name.Equals(oi.ItemName, StringComparison.OrdinalIgnoreCase));

                    if (!IsValid(oi) || item == null)
                    {
                        areAllItemsValid = false;
                        break;
                    }

                    var orderItem = new OrderItem
                    {
                        ItemId = item.Id, 
                        Quantity = oi.Quantity
                    };

                    orderItems.Add(orderItem);
                }

                var employee = context.Employees
                    .FirstOrDefault(e => e.Name.Equals(orderDto.EmployeeName, StringComparison.OrdinalIgnoreCase));

                DateTime date;
                var isDateValid = DateTime.TryParseExact(orderDto.DateTime, 
                    DateFormat, 
                    CultureInfo.InvariantCulture, 
                    DateTimeStyles.None, 
                    out date);

                if (employee == null || !areAllItemsValid || !isDateValid)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var order = new Order
                {
                    Customer = orderDto.Customer, 
                    Employee = employee, 
                    DateTime = date, 
                    Type = orderDto.Type, 
                    OrderItems = orderItems
                };

                sb.AppendLine(string.Format(OrderSuccessMessage, 
                    order.Customer, 
                    order.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture)));

                validOrders.Add(order);
            }

            context.Orders.AddRange(validOrders);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
    }
}