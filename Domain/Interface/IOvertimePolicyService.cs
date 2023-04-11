using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public interface IOvertimePolicyService
    {
        public double CalculatorA(double basicSalary, double allowance, int overTimeHuors);
        public double CalculatorB(double basicSalary, double allowance, int overTimeHuors);
        public double CalculatorC(double basicSalary, double allowance, int overTimeHuors);
    }
}
