using APICrud.Domain.DTOS;

namespace APICrud.Domain.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        List<EmployeeDTO> Get(int pageNumber, int pageQuantity);

        Employee? Get(int id);
    }
}
