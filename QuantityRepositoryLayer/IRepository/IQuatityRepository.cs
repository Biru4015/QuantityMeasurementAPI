namespace QuantityRepositoryLayer.IRepository
{
    using QuantityModelLayer.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is interface of Quantity repository
    /// </summary>
    public interface IQuatityRepository
    {
        /// <summary>
        /// This method  is created for getting list of length
        /// </summary>
        /// <returns></returns>
        List<Length> AllData();

        /// <summary>
        /// This method is created for deleting id of lenght convertor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(int Id);
        
        /// <summary>
        /// This method is created for getting list of volume convertor
        /// </summary>
        /// <returns></returns>
        List<Volume> AllVolumeData();

        /// <summary>
        /// This method is created for deleting id of volume convertor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteVolume(int Id);

        /// <summary>
        /// This method is created for posting the object of volume convertor
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        object PostAll(object volume);

        /// <summary>
        /// This method is created for getting list of all weight convertor
        /// </summary>
        /// <returns></returns>
        List<Weight> AllWeightData();

        /// <summary>
        /// This method is created for deleting the id of weight table
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteWeight(int Id);

        /// <summary>
        /// This method is created for getting tempreture list
        /// </summary>
        /// <returns></returns>
        List<Temperature> AllTemperatureData();

        /// <summary>
        /// This method is created for deleting id of tempreture convertor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteTemperature(int Id);
    }
}
