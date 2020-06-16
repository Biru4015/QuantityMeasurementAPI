namespace QuantityMeasurementRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using QuantityMeasurementModel;
    using QuantityMeasurementRepository;
    using QuantityMeasurementRepository.IRepository;

    /// <summary>
    /// This class contains the code of repository.
    /// </summary>
    public class QuantityRepository:IQuantityRepository
    {
        double result;
        public object LengthPost(LengthUnit value)
        {
            
            try
            {
                if (value.OptionType.Equals(OptionType.FeetToInch.ToString()))
                    result = value.Feet * 12;
                else if (value.OptionType.Equals(OptionType.InchToFeet.ToString()))
                    result = value.Inch / 12;
                else if (value.OptionType.Equals(OptionType.InchToCentiMeter.ToString()))
                    result = value.Inch * 2.54;
                else if (value.OptionType.Equals(OptionType.CentiMeterToInch.ToString()))
                    result = value.Centimeter/ 2.54;
                else if (value.OptionType.Equals(OptionType.YardToFeet.ToString()))
                    result = value.Yard *3;
                else if (value.OptionType.Equals(OptionType.FeetToYard.ToString()))
                    result = value.Feet / 3;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
            return result;
        } 

        public object VolumePost(VolumeUnit value)
        {
            try
            {
                if (value.OptionType.Equals(OptionType.LitreToGallon.ToString()))
                    result = value.Litre / 4.54;
                else if (value.OptionType.Equals(OptionType.GallonToLitre.ToString()))
                    result = value.Gallon * 4.54;
                else if (value.OptionType.Equals(OptionType.LitreToMiliLitre.ToString()))
                    result = value.Litre * 1000;
                else if (value.OptionType.Equals(OptionType.MiliLitreToLitre.ToString()))
                    result = value.Mililitre / 1000;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
            return result;
        }
        public object WeightPost(WeightUnit value)
        {
            try
            {
                if (value.OptionType.Equals(OptionType.KilogramToGram.ToString()))
                    result = value.Kilogram *1000;
                else if (value.OptionType.Equals(OptionType.GramToKilogram.ToString()))
                    result = value.Gram / 1000;
                else if (value.OptionType.Equals(OptionType.TonneToKilogram.ToString()))
                    result = value.Tonee * 1000;
                else if (value.OptionType.Equals(OptionType.KilogramToTonne.ToString()))
                    result = value.Tonee / 1000;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
            return result;
        }
        public object TempreturePost(TempretureUnit value)
        {
            try
            {
                if (value.OptionType.Equals(OptionType.CelciusToFahrenhiet.ToString()))
                    result = value.Celcius * 2.12;
                else if (value.OptionType.Equals(OptionType.FahrenhietToCelcius.ToString()))
                    result = value.Fahrenhiet / 2.12;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
            return result;
        }
    }
}