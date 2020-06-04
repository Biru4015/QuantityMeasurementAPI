namespace QuantityManagerLayer.IManager
{
    using QuantityModelLayer.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is interface of QuantityManager class
    /// </summary>
    public interface IQuantityManager
    {
        /// <summary>
        /// This is adding length id.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        object Post(Length model);

        /// <summary>
        /// This is getting list of length id
        /// </summary>
        /// <returns></returns>
        List<Length> AllData();

        /// <summary>
        /// This is deleting id of length
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int Delete(int Id);

        /// <summary>
        /// This is getting all volume id.
        /// </summary>
        /// <returns></returns>
        List<Volume> AllVolumeData();
        
        /// <summary>
        /// This is deleting volume id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteVolume(int Id);

        /// <summary>
        /// This is adding volume id
        /// </summary>
        /// <param name="vmodel"></param>
        /// <returns></returns>
        object PostV(Volume vmodel);

        /// <summary>
        /// This is getting id of weight
        /// </summary>
        /// <returns></returns>
        List<Weight> AllWeightData();

        /// <summary>
        /// This is deleting Weight id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteWeight(int Id);

        /// <summary>
        /// This is adding Weight id
        /// </summary>
        /// <param name="wmodel"></param>
        /// <returns></returns>
        object PostWeight(Weight wmodel);

        /// <summary>
        /// This is adding tempreture id
        /// </summary>
        /// <param name="tmodel"></param>
        /// <returns></returns>
        object PostTemperature(Temperature tmodel);

        /// <summary>
        /// This is getting all tempreture id
        /// </summary>
        /// <returns></returns>
        List<Temperature> AllTemperatureData();

        /// <summary>
        /// This is deleting tempreture id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteTemperature(int Id);
    }
}
