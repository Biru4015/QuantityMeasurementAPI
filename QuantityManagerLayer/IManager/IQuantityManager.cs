namespace QuantityManagerLayer.IManager
{
    using QuantityModelLayer.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

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
        object PostAllLength(Length model);

        Task<int> UpdateLength(Length lengthChanges);

        /// <summary>
        /// This is getting list of length id
        /// </summary>
        /// <returns></returns>
        List<Length> AllDataLength();

        /// <summary>
        /// This is deleting id of length
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteLength(int Id);

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
        object PostAllVolume(Volume vmodel);

        Task<int> UpdateVolume(Volume lengthChanges);

        /// <summary>
        /// This is getting id of weight
        /// </summary>
        /// <returns></returns>
        List<Weight> AllWeightData();

        /// <summary>
        /// Adding all the data of weight conversion
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        object PostAllWeight(Weight weight);

        Task<int> UpdateWeight(Weight weightChanges);

        /// <summary>
        /// This is deleting Weight id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteWeight(int Id);

        /// <summary>
        /// This is adding tempreture id
        /// </summary>
        /// <param name="tmodel"></param>
        /// <returns></returns>
        object PostAllTempreture(Temperature tmodel);

        Task<int> UpdateTempreture(Temperature lengthChanges);

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
