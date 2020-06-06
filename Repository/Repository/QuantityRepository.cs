namespace QuantityMeasurementRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using QuantityMeasurementModel;
    using QuantityMeasurementRepository;
    using QuantityMeasurementRepository.IRepository;

    /// <summary>
    /// This class contains the code of repository.
    /// </summary>
    public class QuantityRepository:IQuantityRepository
    {
        public double FeetToInch(LengthUnit value)
        {
            double result = value.Feet * 12;
            return result;
        }
        public double InchToFeet(LengthUnit value)
        {
            double result = value.Inch / 12;
            return result;
        }
        public double InchToCentiMeter(LengthUnit value)
        {
            double result = value.Inch * 2.54;
            return result;
        }
        public double CentiMeterToInch(LengthUnit value)
        {
            double result = value.Inch / 2.54;
            return result;
        }

        public double FeetToYard(LengthUnit value)
        {
            double result = value.Feet * 3.0;
            return result;
        }
        public double YardToFeet(LengthUnit value)
        {
            double result = value.Yard / 3.0;
            return result;
        }

        public double GramToKilogram(WeightUnit value)
        {
            double result = value.Gram / 1000;
            return result;
        }
        public double KilogramToGram(WeightUnit value)
        {
            double result = value.Kilogram * 1000;
            return result;
        }
        public double TonneToKilogram(WeightUnit value)
        {
            double result = value.Tonee * 1000;
            return result;
        }
        public double KilogramToTonne(WeightUnit value)
        {
            double result = value.Kilogram / 1000;
            return result;
        }

        public double GallonToLitre(VolumeUnit value)
        {
            double result = value.Gallon * 4.54;
            return result;
        }
        public double LitreToGallon(VolumeUnit value)
        {
            double result = value.Litre / 4.54;
            return result;
        }
        public double LitreToMiliLitre(VolumeUnit value)
        {
            double result = value.Litre * 1000;
            return result;
        }
        public double MiliLitreToLitre(VolumeUnit value)
        {
            double result = value.Mililitre / 1000;
            return result;
        }

        public double FahrenhietToCelcius(TempretureUnit value)
        {
            double result = value.Fahrenhiet / 2.12;
            return result;
        }
        public double CelciusToFahrenhiet(TempretureUnit value)
        {
            double result = value.Celcius * 2.12;
            return result;
        }
    }
}