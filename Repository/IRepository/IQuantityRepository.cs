namespace QuantityMeasurementRepository.IRepository
{
    using QuantityMeasurementModel;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IQuantityRepository
    {
        object LengthPost(LengthUnit value);
        object VolumePost(VolumeUnit value);
        object WeightPost(WeightUnit value);
        object TempreturePost(TempretureUnit value);
    }
}
