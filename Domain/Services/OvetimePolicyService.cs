using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class OvetimePolicyService : IOvertimePolicyService
    {
        const int MonthlyWorkingHours = 220;
        private double _basicSalary;
        private double _allowance;
        private double _overTimeHuors;


        public OvetimePolicyService()
        {
            
        }


        public OvetimePolicyService FactoryMethod(double basicSalary, double allowance, int overTimeHuors)
        {
            _basicSalary = basicSalary;
            _allowance = allowance;
            _overTimeHuors = overTimeHuors;

            return new OvetimePolicyService { _allowance = allowance, _basicSalary = basicSalary, _overTimeHuors = overTimeHuors };
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

        int IOvertimePolicyService.CalcurlatorA()
        {
            throw new NotImplementedException();
        }
    }
}
