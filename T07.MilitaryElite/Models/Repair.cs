﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}");

            return sb.ToString().TrimEnd();
        }
    }
}
