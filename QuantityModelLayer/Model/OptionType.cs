using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityModelLayer.Model
{
    public enum OptionType
    {
        //lengths
        FeetToInch, InchToFeet, YardToInch,
        //volumes
        GallonToLiter, LitreToMilliliter, MilliliterToLiter,
        //Weights
        KgToGrams, TonneToKgs, GramToKg,
        //Temperature
        CelsiusToFahrenheit, FahrenheitToCelsius

    }
}
