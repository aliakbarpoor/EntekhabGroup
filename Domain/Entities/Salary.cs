using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Salary : BaseEntity
    {
      
        public string FullName { get; set; } = string.Empty;
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
        public double Transportation { get; set; }
        public int OveTime { get; set; }
        public double OveTimeGrossValue { get; set; }

        public DateTimeOffset Date { get; set; }
    }
}
