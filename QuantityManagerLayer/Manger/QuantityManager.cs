namespace QuantityManagerLayer.Manger
{
    using QuantityManagerLayer.IManager;
    using QuantityModelLayer.Model;
    using QuantityRepositoryLayer;
    using QuantityRepositoryLayer.IRepository;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains the convertor method of all units
    /// </summary>
    public class QuantityManager: IQuantityManager
    {
        /// <summary>
        /// Object of IQuantityRepository
        /// </summary>
        private readonly IQuatityRepository unitRL;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="unitRepoL"></param>
        public QuantityManager(IQuatityRepository unitRepoL)
        {
            unitRL = unitRepoL;
        }

        /// <summary>
        /// This method is created for converting lengths 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>object</returns>
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
                    model.Result = model.Yard * 3;
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

        /// <summary>
        /// This method is created for getting all the list of lenght conversion
        /// </summary>
        /// <returns>list</returns>
        public List<Length> AllData()
        {
            var a = unitRL.AllData();
            return a;
        }

        /// <summary>
        /// This method is created for deleting id of length conversion
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            var delete = unitRL.Delete(Id);
            return delete;
        }

        /// <summary>
        /// This method is created for adding volume conversion
        /// </summary>
        /// <param name="vmodel"></param>
        /// <returns>object</returns>
        public object PostV(Volume vmodel)
        {
            var res = unitRL.PostAll(vmodel);
            try
            {
                if (vmodel.OptionType.Equals(OptionType.GallonToLiter.ToString()))
                {
                    double litre = 3.78;
                    vmodel.Result = vmodel.Gallon * Convert.ToInt32(litre);
                }
                else if (vmodel.OptionType.Equals(OptionType.LitreToMilliliter.ToString()))
                {
                    vmodel.Result = vmodel.Litre * 1000;
                }
                else if (vmodel.OptionType.Equals(OptionType.MilliliterToLiter.ToString()))
                { 
                    vmodel.Result = vmodel.Millilitre / 1000;
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

        /// <summary>
        /// This method is created for getting list of volume conversion
        /// </summary>
        /// <returns></returns>
        public List<Volume> AllVolumeData()
        {
            var a = unitRL.AllVolumeData();
            return a;
        }

        /// <summary>
        /// This method is created for deleting volume id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>id</returns>
        public int DeleteVolume(int Id)
        {
            var delete = unitRL.DeleteVolume(Id);
            return delete;
        }

        /// <summary>
        /// This method is created for adding weight conversion.
        /// </summary>
        /// <param name="wmodel"></param>
        /// <returns></returns>
        public object PostWeight(Weight wmodel)
        {
            var res = unitRL.PostAll(wmodel);
            try
            {

                if (wmodel.OptionType.Equals(OptionType.KgToGrams.ToString()))
                {
                    wmodel.Result = wmodel.Kg * 1000;
                }
                else if (wmodel.OptionType.Equals(OptionType.GramToKg.ToString()))
                {
                    wmodel.Result = wmodel.Gram / 1000;
                }
                else if (wmodel.OptionType.Equals(OptionType.TonneToKgs.ToString()))
                {
                    wmodel.Result = wmodel.Ton * 1000;
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

        /// <summary>
        /// This method is created for getting list of weight
        /// </summary>
        /// <returns>list</returns>
        public List<Weight> AllWeightData()
        {
            var a = unitRL.AllWeightData();
            return a;
        }

        /// <summary>
        /// This method is created for deleting id of weight conversion
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>id</returns>
        public int DeleteWeight(int Id)
        {
            var delete = unitRL.DeleteWeight(Id);
            return delete;
        }

        /// <summary>
        /// This method is adding tempreture conversion
        /// </summary>
        /// <param name="tmodel"></param>
        /// <returns>object</returns>
        public object PostTemperature(Temperature tmodel)
        {
            var res = unitRL.PostAll(tmodel);
            try
            {
                if (tmodel.OptionType.Equals(OptionType.CelsiusToFahrenheit.ToString()))
                {

                    tmodel.Result = (tmodel.Celsius * 9 / 5) + 32;
                }
                else if (tmodel.OptionType.Equals(OptionType.FahrenheitToCelsius.ToString()))
                {

                    tmodel.Result = (tmodel.Fahrenheit - 32)* 5 / 9;
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

        /// <summary>
        /// This method is created for getting list of tempreture conversion
        /// </summary>
        /// <returns>list</returns>
        public List<Temperature> AllTemperatureData()
        {
            var a = unitRL.AllTemperatureData();
            return a;
        }

        /// <summary>
        /// This method is created for deleting id of tempreture
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DeleteTemperature(int Id)
        {
            var delete = unitRL.DeleteTemperature(Id);
            return delete;
        }
    }
}