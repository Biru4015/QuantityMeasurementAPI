namespace QuantityModelLayer.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains the code for Option type convertor
    /// </summary>
    public enum OptionType
    {
        //// All type of lengths invludes
        FeetToInch, InchToFeet, YardToInch,
        
        //// All type of volumes includes
        GallonToLiter, LitreToMilliliter, MilliliterToLiter,
        
        //// All type of Weights includes
        KgToGrams, TonneToKgs, GramToKg,
        
        // All type of Temperatures includes
        CelsiusToFahrenheit, FahrenheitToCelsius
    }
}
