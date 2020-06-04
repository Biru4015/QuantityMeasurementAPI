using QuantityModelLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityRepositoryLayer.IRepository
{
    public interface IQuatityRepository
    {
        //// Task<double> Post(Unit unit);
        //// decimal Post(Unit unit);
        ////  Unit DisplayAll();
        List<Length> AllData();

        int Delete(int Id);
        
        //// Decimal PostVolume(Volume vmodel);
        List<Volume> AllVolumeData();

        int DeleteVolume(int Id);

        object PostAll(object volume);

        List<Weight> AllWeightData();

        int DeleteWeight(int Id);

        List<Temperature> AllTemperatureData();

        int DeleteTemperature(int Id);

    }
}
