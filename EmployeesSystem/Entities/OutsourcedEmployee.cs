﻿namespace EmployeesSystem.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }
        
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return Hours * ValuePerHour + 1.1 * AdditionalCharge;
        }
    }
}
