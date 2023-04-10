using API.Enums;
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

            var policy = _overtimePolicyService.FactoryMethod(salaryToAdd.BasicSalary, salaryToAdd.Allowance, salary.OveTime);

            double overTimeGrossValue;
            switch (overTimeCalculator)
            {
                case "CalculatorA":

                    overTimeGrossValue = policy.CalcurlatorA();
                    break;
                case "CalculatorB":
                    overTimeGrossValue = policy.CalcurlatorB();
                    break;
                case "CalculatorC":
                    overTimeGrossValue = policy.CalcurlatorC();

                    break;
                default:
                    overTimeGrossValue = policy.CalcurlatorA();
                    break;
            }

            salaryToAdd.OveTimeGrossValue = overTimeGrossValue;

            var s = await _repository.Add(salaryToAdd);

            return _mapper.Map<SalaryDto>(s);



        }

        public Task Delete(SalaryDto salary)
        {
            throw new NotImplementedException();
        }

        public Task<List<SalaryDto>> GetRange(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public async Task<SalaryDto> Get(int id)
        {
            return _mapper.Map<SalaryDto>(await _repository.Get(id));

        }

        public Task<SalaryDto> Update(SalaryDto salary)
        {
            throw new NotImplementedException();
        }


    }
}
