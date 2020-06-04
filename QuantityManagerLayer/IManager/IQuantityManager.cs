using QuantityModelLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityManagerLayer.IManager
{
    public interface IQuantityManager
    {
        // decimal Post(Unit unit);
        //Task<List<Unit>> AllData();
        // Unit DisplayAll();

        object Post(Length model);

        List<Length> AllData();

        int Delete(int Id);

        //  decimal PostVolume(Volume vmodel);

        List<Volume> AllVolumeData();

        int DeleteVolume(int Id);

        object PostV(Volume vmodel);


        List<Weight> AllWeightData();

        int DeleteWeight(int Id);

        object PostWeight(Weight wmodel);

        object PostTemperature(Temperature tmodel);

        List<Temperature> AllTemperatureData();

        int DeleteTemperature(int Id);
    }
}
