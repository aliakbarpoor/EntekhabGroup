using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class SalaryDto
    {
        public int Id { get; set; }
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
        public double Transportation { get; set; }
        public double OveTime { get; set; }
        public double GorssValue { get; set; }

    }
}
