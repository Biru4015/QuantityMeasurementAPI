namespace QuantityMeasurementManager.QuantityManager
{
    using QuantityMeasurementManager.IQuantityManager;
    using QuantityMeasurementModel;
    using QuantityMeasurementRepository.IRepository;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains the QuantityMeasurement
    /// </summary>
    public class QuantityMeasurementManagers:IQuantityMeasurementManager
    {
        /// <summary>
        /// Calling the IQuantityRepository.
        /// </summary>
        private IQuantityRepository repo;

        /// <summary>
        /// Parametereized constructor.
        /// </summary>
        /// <param name="repo"></param>
        public QuantityMeasurementManagers(IQuantityRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// This method is created for converting Feet to inch.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FeetToInch(LengthUnit value)
        {
            return this.repo.FeetToInch(value);
        }

        /// <summary>
        /// This method is  created for converting inch to feet.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double InchToFeet(LengthUnit value)
        {
            return this.repo.InchToFeet(value);
        }
        
        /// <summary>
        /// This method is created for converting inch to centimeter
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double InchToCentiMeter(LengthUnit value)
        {
            return this.repo.InchToCentiMeter(value);
        }

        /// <summary>
        /// This  method is created for converting centimter to inch.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double CentiMeterToInch(LengthUnit value)
        {
            return this.repo.CentiMeterToInch(value);
        }

        /// <summary>
        /// This method is created to converting feet to yard.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FeetToYard(LengthUnit value)
        {
            return this.repo.FeetToYard(value);
        }

        /// <summary>
        /// This method is created for conveting yard to feet.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double YardToFeet(LengthUnit value)
        {
            return this.repo.YardToFeet(value);
        }

        /// <summary>
        /// This method is converting grams to kilograms.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double GramToKilogram(WeightUnit value)
        {
            return this.repo.GramToKilogram(value);
        }

        /// <summary>
        /// This method is created for converting kilogram to grams.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double KilogramToGram(WeightUnit value)
        {
            return this.repo.KilogramToGram(value);
        }

        /// <summary>
        /// This method is converting tonne to kilogram.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double TonneToKilogram(WeightUnit value)
        {
            return this.repo.TonneToKilogram(value);
        }
        public double KilogramToTonne(WeightUnit value)
        {
            return this.repo.KilogramToTonne(value);
        }

        /// <summary>
        /// This method is created for converting gallon to litres.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double GallonToLitre(VolumeUnit value)
        {
            return this.repo.GallonToLitre(value);
        }

        /// <summary>
        /// This method is created for converting litre to gallon.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double LitreToGallon(VolumeUnit value)
        {
            return this.repo.LitreToGallon(value);
        }
        
        /// <summary>
        /// This method is created for converting litre to mililitres.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double LitreToMiliLitre(VolumeUnit value)
        {
            return this.repo.LitreToMiliLitre(value);
        }

        /// <summary>
        /// This method is created for converting mililitre to litre.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double MiliLitreToLitre(VolumeUnit value)
        {
            return this.repo.MiliLitreToLitre(value);
        }

        /// <summary>
        /// This method is created for converting fahrenhiet to celcius.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FahrenhietToCelcius(TempretureUnit value)
        {
            return this.repo.FahrenhietToCelcius(value);
        }

        /// <summary>
        /// This method is created for converting celcius to fahrenheit.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double CelciusToFahrenhiet(TempretureUnit value)
        {
            return this.repo.CelciusToFahrenhiet(value);
        }
    }
}
