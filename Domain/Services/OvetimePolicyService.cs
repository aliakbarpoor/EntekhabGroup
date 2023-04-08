using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class OvetimePolicyService : IOvetimePolicyService
    {
        const int MonthlyWorkingHours = 220;
        private readonly int _basicSalary;
        private readonly int _allowance;
        private readonly int _overTimeHuors;

        public OvetimePolicyService(int basicSalary, int allowance, int overTimeHuors)
        {
            _basicSalary = basicSalary;
            _allowance = allowance;
            _overTimeHuors = overTimeHuors;
        }
        public double CalcurlatorA()
        {

            var overTime = ((_basicSalary + _allowance) / MonthlyWorkingHours) * 1.4 * _overTimeHuors;
            return overTime;
        }

        public int CalcurlatorB()
        {
            throw new NotImplementedException();
        }

        public int CalcurlatorC()
        {
            throw new NotImplementedException();
        }

        int IOvetimePolicyService.CalcurlatorA()
        {
            throw new NotImplementedException();
        }
    }
}
