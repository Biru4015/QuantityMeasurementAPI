using QuantityMeasurementModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.IRepository
{
    public interface IQuantityRepository
    {
        double FeetToInch(LengthUnit value);
        double InchToFeet(LengthUnit value);
        double InchToCentiMeter(LengthUnit value);
        double CentiMeterToInch(LengthUnit value);
        double YardToFeet(LengthUnit value);
        double FeetToYard(LengthUnit value);
        double KilogramToGram(WeightUnit value);
        double GramToKilogram(WeightUnit value);
        double TonneToKilogram(WeightUnit value);
        double KilogramToTonne(WeightUnit value);
        double LitreToGallon(VolumeUnit value);
        double GallonToLitre(VolumeUnit value);
        double LitreToMiliLitre(VolumeUnit value);
        double MiliLitreToLitre(VolumeUnit value);
        double FahrenhietToCelcius(TempretureUnit value);
        double CelciusToFahrenhiet(TempretureUnit value);
    }
}
