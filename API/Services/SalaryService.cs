using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interface;

namespace API.Services
{


    public class SalaryService : ISalaryService
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Salary> _repository;
        private readonly IOvertimePolicyService _overtimePolicyService;

        public SalaryService(IMapper mapper, IAsyncRepository<Salary> repository, IOvertimePolicyService overtimePolicyService)
        {
            _mapper = mapper;
            _repository = repository;
            _overtimePolicyService = overtimePolicyService;
        }
        public async Task<SalaryDto> Add(SalaryDto salary, string overTimeCalculator)
        {

            if (salary == null)
            {
                throw new ArgumentNullException();
            }

            var salaryToAdd = _mapper.Map<Salary>(salary);



            double overTimeGrossValue;
            switch (overTimeCalculator)
            {
                case "CalculatorA":

                    overTimeGrossValue = _overtimePolicyService.CalculatorA(salaryToAdd.BasicSalary, salaryToAdd.Allowance, salary.OverTime);
                    break;
                case "CalculatorB":
                    overTimeGrossValue = _overtimePolicyService.CalculatorB(salaryToAdd.BasicSalary, salaryToAdd.Allowance, salary.OverTime);
                    break;
                case "CalculatorC":
                    overTimeGrossValue = _overtimePolicyService.CalculatorC(salaryToAdd.BasicSalary, salaryToAdd.Allowance, salary.OverTime);

                    break;
                default:
                    overTimeGrossValue = _overtimePolicyService.CalculatorA(salaryToAdd.BasicSalary, salaryToAdd.Allowance, salary.OverTime);
                    break;
            }

            salaryToAdd.OveTimeGrossValue = overTimeGrossValue;

            var s = await _repository.Add(salaryToAdd);

            return _mapper.Map<SalaryDto>(s);



        }

        public async Task Delete(SalaryDto salary)
        {

            var salaryToDelete = await _repository.Get(salary.Id);

            if (salaryToDelete == null)
                throw new NullReferenceException();

            await _repository.Delete(salaryToDelete);

        }

        public Task<List<SalaryDto>> GetRange(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public async Task<SalaryDto> Get(int id)
        {
            return _mapper.Map<SalaryDto>(await _repository.Get(id));

        }

        public async Task<SalaryDto> Update(SalaryDto salary)
        {

            var salaryToUpdate = _mapper.Map<Salary>(salary);


            return _mapper.Map<SalaryDto>(await _repository.Update(salaryToUpdate));
        }


    }
}
