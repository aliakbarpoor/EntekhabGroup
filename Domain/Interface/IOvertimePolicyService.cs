using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public interface IOvertimePolicyService
    {
        public OvetimePolicyService FactoryMethod(double basicSalary, double allowance, int overTimeHuors);
        public int CalcurlatorA();
        public int CalcurlatorB();
        public int CalcurlatorC();
    }
}
