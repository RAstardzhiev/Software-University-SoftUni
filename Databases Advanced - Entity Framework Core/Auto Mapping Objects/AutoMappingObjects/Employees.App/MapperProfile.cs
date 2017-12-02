namespace Employees.App
{
    using AutoMapper;
    using Employees.App.DTOs;
    using Employees.Models;

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<EmployeeDto, Employee>();
            CreateMap<ManagerDto, Employee>();
        }
    }
}
