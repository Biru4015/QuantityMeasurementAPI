namespace QuantityRepositoryLayer.IRepository
{
    using QuantityModelLayer.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is interface of Quantity repository
    /// </summary>
    public interface IQuatityRepository
    {
        /// <summary>
        /// This method  is created for getting list of length
        /// </summary>
        /// <returns></returns>
        List<Length> AllDataLength();

        /// <summary>
        /// This method is created for deleting id of lenght convertor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteLength(int Id);

        /// <summary>
        /// Adding length data
        /// </summary>
        /// <param name="Length"></param>
        /// <returns></returns>
        object PostAllLength(object Length);

        /// <summary>
        /// This method is created for updating length conversion
        /// </summary>
        /// <param name="lengthChanges"></param>
        /// <returns></returns>
        Task<int> UpdateLength(Length lengthChanges);

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
        object PostAllVolume(object volume);

        /// <summary>
        /// This method is creating updating volume  conversion
        /// </summary>
        /// <param name="lengthChanges"></param>
        /// <returns></returns>
        Task<int> UpdateVolume(Volume lengthChanges);

        /// <summary>
        /// This method is created for getting list of all weight convertor
        /// </summary>
        /// <returns></returns>
        List<Weight> AllWeightData();

        /// <summary>
        /// Adding weigth conversion data
        /// </summary>
        /// <param name="Weight"></param>
        /// <returns></returns>
        object PostAllWeight(object Weight);

        /// <summary>
        /// This method is created for updating weight conversion
        /// </summary>
        /// <param name="weightChanges"></param>
        /// <returns></returns>
        Task<int> UpdateWeight(Weight weightChanges);

        /// <summary>
        /// This method is created for deleting the id of weight table
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteWeight(int Id);

        /// <summary>
        /// Adding tempreture conversion data
        /// </summary>
        /// <param name="Tempreture"></param>
        /// <returns></returns>
        object PostAllTempreture(object Tempreture);

        /// <summary>
        /// This method is creating for updating tempreture conversion
        /// </summary>
        /// <param name="lengthChanges"></param>
        /// <returns></returns>
        Task<int> UpdateTempreture(Temperature lengthChanges);

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
