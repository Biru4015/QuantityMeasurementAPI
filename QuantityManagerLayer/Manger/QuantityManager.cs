using QuantityManagerLayer.IManager;
using QuantityModelLayer.Model;
using QuantityRepositoryLayer;
using QuantityRepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityManagerLayer.Manger
{
    public class QuantityManager: IQuantityManager
    {
        private readonly IQuatityRepository unitRL;
        public QuantityManager(IQuatityRepository unitRepoL)
        {
            unitRL = unitRepoL;
        }
        public object Post(Length model)
        {

            var res = unitRL.PostAll(model);

            try
            {
                if (model.OptionType.Equals(OptionType.FeetToInch.ToString()))
                {
                    model.Result = model.Feet * 12;
                }
                else if (model.OptionType.Equals(OptionType.InchToFeet.ToString()))
                {
                    model.Result = model.Inch / 12;
                }
                else if (model.OptionType.Equals(OptionType.YardToInch.ToString()))
                {
                    model.Result = model.Yard / 3;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
                }
                return res;
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
        }

        public List<Length> AllData()
        {
            var a = unitRL.AllData();
            return a;
        }

        public int Delete(int Id)
        {
            var delete = unitRL.Delete(Id);
            return delete;
        }

        //// Volume
        public object PostV(Volume vmodel)
        {
            var res = unitRL.PostAll(vmodel);
            try
            {
                if (vmodel.OptionType.Equals(OptionType.GallonToLiter.ToString()))
                {
                    double litre = 3.78;
                    vmodel.Result = vmodel.Gallon * Convert.ToInt32(litre);
                    //  return model.Result;
                }
                else if (vmodel.OptionType.Equals(OptionType.LitreToMilliliter.ToString()))
                {
                    //double litre = 3.78;
                    vmodel.Result = vmodel.Litre * 1000;
                    //  return model.Result;
                }
                else if (vmodel.OptionType.Equals(OptionType.MilliliterToLiter.ToString()))
                {
                    //double litre = 3.78;
                    vmodel.Result = vmodel.Millilitre / 1000;
                    //  return model.Result;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
                }
                return res;
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
        }
        public List<Volume> AllVolumeData()
        {
            var a = unitRL.AllVolumeData();
            return a;
        }

        public int DeleteVolume(int Id)
        {
            var delete = unitRL.DeleteVolume(Id);
            return delete;
        }

        //// Weights
        public object PostWeight(Weight wmodel)
        {
            var res = unitRL.PostAll(wmodel);
            try
            {

                if (wmodel.OptionType.Equals(OptionType.KgToGrams.ToString()))
                {
                    //double litre = 3.78;
                    wmodel.Result = wmodel.Kg * 1000;
                    //  return model.Result;
                }
                else if (wmodel.OptionType.Equals(OptionType.GramToKg.ToString()))
                {
                    //double litre = 3.78;
                    wmodel.Result = wmodel.Gram / 1000;
                    //  return model.Result;
                }
                else if (wmodel.OptionType.Equals(OptionType.TonneToKgs.ToString()))
                {
                    //double litre = 3.78;
                    wmodel.Result = wmodel.Ton * 900;
                    //  return model.Result;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
                }
                return res;
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
        }

        public List<Weight> AllWeightData()
        {
            var a = unitRL.AllWeightData();
            return a;
        }

        public int DeleteWeight(int Id)
        {
            var delete = unitRL.DeleteWeight(Id);
            return delete;
        }

        //// Temperature
        public object PostTemperature(Temperature tmodel)
        {
            var res = unitRL.PostAll(tmodel);
            try
            {
                if (tmodel.OptionType.Equals(OptionType.CelsiusToFahrenheit.ToString()))
                {

                    tmodel.Result = (tmodel.Celsius * 9 / 5) + 32;
                    //  return model.Result;
                }
                else if (tmodel.OptionType.Equals(OptionType.FahrenheitToCelsius.ToString()))
                {

                    tmodel.Result = (tmodel.Fahrenheit - 32)* 5 / 9;
                    //  return model.Result;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
                }
                return res;
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.TYPE_NOT_MATCH, "Conversion Not Match");
            }
        }

        public List<Temperature> AllTemperatureData()
        {
            var a = unitRL.AllTemperatureData();
            return a;
        }

        public int DeleteTemperature(int Id)
        {
            var delete = unitRL.DeleteTemperature(Id);
            return delete;
        }
    }
}
