using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using FastFood.Data;
using FastFood.DataProcessor.Dto.Export;
using FastFood.Models.Enums;
using Newtonsoft.Json;

namespace FastFood.DataProcessor
{
	public class Serializer
	{
		public static string ExportOrdersByEmployee(FastFoodDbContext context, string employeeName, string orderType)
		{
            OrderType typeOfOrder;
            var isTypeValid = Enum.TryParse(orderType, out typeOfOrder);

            var employeeOrders = context.Employees
                .Select(e => new
                {
                    Name = e.Name,
                    Orders = e.Orders
                        .Where(o => o.Type == typeOfOrder)
                        .Select(o => new
                        {
                            Customer = o.Customer,
                            Items = o.OrderItems.Select(oi => new
                            {
                                Name = oi.Item.Name,
                                Price = oi.Item.Price,
                                Quantity = oi.Quantity
                            }),
                            TotalPrice = o.TotalPrice
                        })
                        .OrderByDescending(o => o.TotalPrice)
                        .ThenByDescending(o => o.Items.Count())
                })
                .FirstOrDefault(e => e.Name.Equals(employeeName, StringComparison.OrdinalIgnoreCase));

            var ordersByEmployee = new
            {
                employeeOrders.Name,
                employeeOrders.Orders,
                TotalMade = employeeOrders.Orders
                        .Select(o => o.TotalPrice)
                        .Sum()
            };

            var jsonString = JsonConvert.SerializeObject(ordersByEmployee, Newtonsoft.Json.Formatting.Indented);
            return jsonString;
		}

		public static string ExportCategoryStatistics(FastFoodDbContext context, string categoriesString)
		{
            var categoriesNames = categoriesString.Split(',');

            var stats = context.Categories
                .Where(c => categoriesNames.Any(n => n.Equals(c.Name, StringComparison.OrdinalIgnoreCase)))
                .Select(c => new
                {
                    Name = c.Name,
                    TopItem = c.Items
                        .OrderByDescending(i => i.OrderItems
                        .Sum(oi => oi.Quantity * oi.Item.Price))
                    .FirstOrDefault()
                })
                .Select(c => new CategoryStatDto
                {
                    Name = c.Name,
                    MostPopularItem = new MostPopularItem
                    {
                        Name = c.TopItem.Name,
                        TimesSold = c.TopItem.OrderItems
                            .Select(oi => oi.Quantity)
                            .Sum(),
                        TotalMade = c.TopItem.OrderItems
                            .Sum(oi => oi.Quantity * oi.Item.Price)
                    }
                })
                .OrderByDescending(c => c.MostPopularItem.TotalMade)
                .ThenByDescending(c => c.MostPopularItem.TimesSold)
                .ToArray();

            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(CategoryStatDto[]), new XmlRootAttribute("Categories"));
            serializer.Serialize(new StringWriter(sb), stats, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

            var result = sb.ToString();
            return result;
        }
	}
}