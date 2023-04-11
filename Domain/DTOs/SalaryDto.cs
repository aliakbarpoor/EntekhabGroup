using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class SalaryDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
        public double Transportation { get; set; }
        public int OverTime { get; set; }
        public double OveTimeGrossValue { get; set; }
        public double TotalGorssValue => BasicSalary + Allowance + OveTimeGrossValue;
        public string Date { get; set; }= string.Empty;

    }
}
