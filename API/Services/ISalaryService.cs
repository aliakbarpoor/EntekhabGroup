using API.Enums;
using Domain.DTOs;

namespace API.Services
{
    public interface ISalaryService
    {

        public Task<SalaryDto> Get(int id);
        public Task<List<SalaryDto>> GetRange(DateTime start, DateTime end);

        public Task<SalaryDto> Add(SalaryDto salary, string overTimeCalculator);

        public Task<SalaryDto> Update(SalaryDto salary);

        public Task Delete(SalaryDto salary);


    }
}




