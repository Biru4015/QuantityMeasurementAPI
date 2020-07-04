using QuantityMeasurementModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementManager.IQuantityManager
{
    public interface IQuantityMeasurementManager
    {
        object LengthPost(LengthUnit value);
        object VolumePost(VolumeUnit value);
        object WeightPost(WeightUnit value);
        object TempreturePost(TempretureUnit value);
    }
}
