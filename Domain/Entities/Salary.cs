using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Salary : BaseEntity
    {
        public int EnployeeId { get; set; }
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
        public double Transportation { get; set; }
        public double GorssValue { get; set; }
        public double OveTime { get; set; }
    }
}
