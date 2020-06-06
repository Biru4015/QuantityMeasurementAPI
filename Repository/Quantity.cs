using QuantityMeasurementRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository
{
    public class Quantity
    {
        private double value;
        private  Unit unit;

        public Quantity() { }

        public Quantity(Unit unit,Double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //// If Object is Null It Will Return False.
            if (obj == null||this.GetType()!=obj.GetType())
                return false;
            if (obj == this)
                return true;
            Quantity that=(Quantity)obj;
            
            return Double.Equals(that.unit.GetConvertedValue(that.value),this.unit.GetConvertedValue(this.value));
        }

        public Quantity AddedQuantity(Quantity that)
        {
            return new Quantity(Unit.KILOGRAM, this.unit.GetConvertedValue(this.value) + that.unit.GetConvertedValue(that.value));
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}