using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementModel
{
    public enum OptionType
    {
        //lengths
        FeetToInch, InchToFeet, InchToCentiMeter, CentiMeterToInch, YardToFeet, FeetToYard,
        //volumes
        LitreToGallon, GallonToLitre, LitreToMiliLitre, MiliLitreToLitre,
        //Weights
        KilogramToGram, GramToKilogram, TonneToKilogram, KilogramToTonne,
        //Temperature
        FahrenhietToCelcius, CelciusToFahrenhiet
    }
}
