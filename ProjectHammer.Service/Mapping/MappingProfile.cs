using AutoMapper;
using ProjectHammer.DAL.Entities;
using ProjectHammer.Service.Models;

namespace ProjectHammer.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Department, DepartmentPoco>();
                cfg.CreateMap<Employee, EmployeePoco>();
                cfg.CreateMap<Login, LoginPoco>();
                cfg.CreateMap<DepartmentView, DepartmentViewPoco>();
            });

          
        }

    }
}
