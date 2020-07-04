using QuantityMeasurementModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.IRepository
{
    public interface IQuantityRepository
    {
        object LengthPost(LengthUnit value);
        object VolumePost(VolumeUnit value);
        object WeightPost(WeightUnit value);
        object TempreturePost(TempretureUnit value);
    }
}
