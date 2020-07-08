using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementModel
{
    public class Queries
    {
       public static string insertLengthQuery = "insert into QUANTITYMESUREMENT.Length(Id,Feet ,Inch ,Yard ,Centimeter ,OptionType ) values(:Id,:Feet,:Inch,:Yard,:Centimeter,:OptionType)";
       public static string insertTempretureQuery= "insert into QUANTITYMESUREMENT.Temperature(Id,Fahrenheit ,Celsius ,OptionType ) values(:Id,:celcius ,:fahrenhiet ,:OptionType)";
       public static string insertVolumeQuery= "insert into QUANTITYMESUREMENT.Volume(Id,Liter ,Milliliter ,Gallon ,OptionType ) values(:Id,:litre,:milimeter,:Gallon,:OptionType)";
       public static string inserWeightQuery= "insert into QUANTITYMESUREMENT.Weight(Id,Kilogram ,Gram ,Tonne ,OptionType ) values(:Id,:Kilogram,:Gram,:Tonne,:OptionType)";
    }
}