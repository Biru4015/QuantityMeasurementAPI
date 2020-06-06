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
        /// <summary>
        /// This method is created for converting feet to inch.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FeetToInch(LengthUnit value)
        {
            double result = value.Feet * 12;
            return result;
        }

        /// <summary>
        /// This method is created for converting inch to feet.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double InchToFeet(LengthUnit value)
        {
            double result = value.Inch / 12;
            return result;
        }

        /// <summary>
        /// This method is created for converting inch to centi meter.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double InchToCentiMeter(LengthUnit value)
        {
            double result = value.Inch * 2.54;
            return result;
        }

        /// <summary>
        /// This method is created for conveting centimeter to inch
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double CentiMeterToInch(LengthUnit value)
        {
            double result = value.Inch / 2.54;
            return result;
        }

        /// <summary>
        /// This method is created for converting feet to yard.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FeetToYard(LengthUnit value)
        {
            double result = value.Feet * 3.0;
            return result;
        }

        /// <summary>
        /// This method is created for converting yard to feet.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double YardToFeet(LengthUnit value)
        {
            double result = value.Yard / 3.0;
            return result;
        }

        /// <summary>
        /// This method is created for converting grams to kilogram.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double GramToKilogram(WeightUnit value)
        {
            double result = value.Gram / 1000;
            return result;
        }

        /// <summary>
        /// This method is created for converting kilogram to grams.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double KilogramToGram(WeightUnit value)
        {
            double result = value.Kilogram * 1000;
            return result;
        }

        /// <summary>
        /// This method is created for converting tonne to kilograms.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method is created for conveting gallon to litre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double GallonToLitre(VolumeUnit value)
        {
            double result = value.Gallon * 4.54;
            return result;
        }

        /// <summary>
        /// This method is created for converting litre  to gallon
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double LitreToGallon(VolumeUnit value)
        {
            double result = value.Litre / 4.54;
            return result;
        }

        /// <summary>
        /// This method is created for converting litre to mililitre 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double LitreToMiliLitre(VolumeUnit value)
        {
            double result = value.Litre * 1000;
            return result;
        }

        /// <summary>
        /// This method is created converting mililitre to litre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double MiliLitreToLitre(VolumeUnit value)
        {
            double result = value.Mililitre / 1000;
            return result;
        }

        /// <summary>
        /// This method is created for converting fahrenheit to celcius.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FahrenhietToCelcius(TempretureUnit value)
        {
            double result = value.Fahrenhiet / 2.12;
            return result;
        }

        /// <summary>
        /// This method is created for converting celcius to fahrenheit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double CelciusToFahrenhiet(TempretureUnit value)
        {
            double result = value.Celcius * 2.12;
            return result;
        }
    }
}