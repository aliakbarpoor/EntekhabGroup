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


 



        public double CalculatorA(double basicSalary, double allowance, int overTimeHuors)
        {
            _basicSalary = basicSalary;
            _allowance = allowance;
            _overTimeHuors = overTimeHuors;     

            var overTime = ((_basicSalary + _allowance) / MonthlyWorkingHours) * 1.4 * _overTimeHuors;
            return overTime;
        }

        public double CalculatorB(double basicSalary, double allowance, int overTimeHuors)
        {
            throw new NotImplementedException();
        }

        public double CalculatorC(double basicSalary, double allowance, int overTimeHuors)
        {
            throw new NotImplementedException();
        }


    }
}
