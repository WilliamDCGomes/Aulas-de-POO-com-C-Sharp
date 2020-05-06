﻿namespace Exercicio_Resolvido_4.Entities {
    class OutsourcedEmployee : Employes{
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() {
        }
        public OutsourcedEmployee(string name, int hours, double valuePerHour,double additionalCharge):base(name, hours, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
