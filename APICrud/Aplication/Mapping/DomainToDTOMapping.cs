using APICrud.Domain.DTOS;
using APICrud.Domain.Model;
using AutoMapper;

namespace APICrud.Aplication.Mapping
{
    public class DomainToDTOMapping : Profile
    {

        public DomainToDTOMapping() 
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        } 

    }
}
