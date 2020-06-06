using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository
{
    public class Unit
    {
        public static readonly Unit FEET = new Unit(12.0);
        public static readonly Unit INCH = new Unit(1.0);
        public static readonly Unit CENTIMETER = new Unit(0.4);
        public static readonly Unit YARD = new Unit(36.0);
        public static readonly Unit LITRE = new Unit(1.0);
        public static readonly Unit GALLON = new Unit(3.78);
        public static readonly Unit MILILITRE = new Unit(0.001);
        public static readonly Unit KILOGRAM = new Unit(1.0);
        public static readonly Unit GRAM = new Unit(0.001);
        public static readonly Unit TONNE = new Unit(1000);
        public static readonly Unit FAHRENHIET = new Unit(1.0);
        public static readonly Unit CELCIUS = new Unit(2.12);

        private double ConversionFactor;

        public Unit()
        {
        }

        private Unit(double baseUnitConvertor)
            => (ConversionFactor) = (baseUnitConvertor);

        public double GetConvertedValue(double value)
        {
            return this.ConversionFactor * value;
        }
    }
}