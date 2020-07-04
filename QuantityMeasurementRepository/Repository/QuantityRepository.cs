using QuantityMeasurementModel;
using QuantityMeasurementRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository.Repository
{
    public class QuantityRepository : IQuantityRepository
    {
        public object LengthPost(LengthUnit quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURES.Length(Feet ,Inch ,Yard ,Centimeter ,OptionType ) values(:Feet,:Inch,:Yard,:Centimeter,:OptionType)";
                using (var _db = new Oracle.ManagedDataAccess.Client.OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(commandText, _db))
                {
                    if (quantity.OptionType == OptionType.FeetToInch.ToString())
                    {
                        quantity.Inch = quantity.Feet * 12;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Inch;
                    }
                    else if (quantity.OptionType == OptionType.InchToFeet.ToString())
                    {
                        quantity.Feet = quantity.Inch / 12;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Feet;
                    }
                    else if (quantity.OptionType == OptionType.FeetToYard.ToString())
                    {
                        quantity.Feet = quantity.Yard / 3;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Feet;
                    }
                    else if (quantity.OptionType == OptionType.CentiMeterToInch.ToString())
                    {
                        quantity.Inch = quantity.Centimeter / 2.54;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Inch;
                    }
                    else if (quantity.OptionType == OptionType.InchToCentiMeter.ToString())
                    {
                        quantity.Centimeter = quantity.Inch * 2.54;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Centimeter;
                    }
                    else if (quantity.OptionType.Equals(OptionType.YardToFeet.ToString()))
                    {
                        quantity.Feet = quantity.Yard * 3;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Yard;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public object TempreturePost(TempretureUnit quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURES.Temperature(Fahrenheit ,Celsius ,OptionType ) values(:celcius ,:fahrenhiet ,:OptionType)";
                using (var _db = new Oracle.ManagedDataAccess.Client.OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(commandText, _db))
                {
                    if (quantity.OptionType == OptionType.FahrenhietToCelcius.ToString())
                    {
                        quantity.celcius = ((quantity.fahrenhiet - 32) * 5 / 9);
                        cmd.Connection = _db;
                        cmd.Parameters.Add("fahrenhiet", quantity.fahrenhiet);
                        cmd.Parameters.Add("celcius", quantity.celcius);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.celcius;
                    }
                    else if (quantity.OptionType == OptionType.CelciusToFahrenhiet.ToString())
                    {
                        quantity.fahrenhiet = ((quantity.celcius * 9 / 5) + 32);
                        cmd.Connection = _db;
                        cmd.Parameters.Add("fahrenhiet", quantity.fahrenhiet);
                        cmd.Parameters.Add("celcius", quantity.celcius);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.fahrenhiet;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public object VolumePost(VolumeUnit quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURES.Volume(Liter ,Milliliter ,Gallon ,OptionType ) values(:litre,:milimeter,:Gallon,:OptionType)";
                using (var _db = new Oracle.ManagedDataAccess.Client.OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(commandText, _db))
                {
                    if (quantity.OptionType == OptionType.MiliLitreToLitre.ToString())
                    {
                        quantity.litre = quantity.milimeter / 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("litre", quantity.litre);
                        cmd.Parameters.Add("milimeter", quantity.milimeter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.litre;
                    }
                    else if (quantity.OptionType == OptionType.LitreToMiliLitre.ToString())
                    {
                        quantity.milimeter = quantity.litre * 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("litre", quantity.litre);
                        cmd.Parameters.Add("milimeter", quantity.milimeter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.milimeter;
                    }
                    else if (quantity.OptionType == OptionType.LitreToGallon.ToString())
                    {
                        quantity.Gallon = quantity.litre / 3.785;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("litre", quantity.litre);
                        cmd.Parameters.Add("milimeter", quantity.milimeter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Gallon;
                    }
                    else if (quantity.OptionType == OptionType.GallonToLitre.ToString())
                    {
                        quantity.litre = quantity.Gallon * 3.785;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("litre", quantity.litre);
                        cmd.Parameters.Add("milimeter", quantity.milimeter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.litre;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public object WeightPost(WeightUnit quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURES.Weight(Kilogram ,Gram ,Tonee ,OptionType ) values(:Kilogram,:Gram,:Tonee,:OptionType)";
                using (var _db = new Oracle.ManagedDataAccess.Client.OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(commandText, _db))
                {
                    if (quantity.OptionType == OptionType.KilogramToGram.ToString())
                    {
                        quantity.Gram = quantity.Kilogram / 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonee", quantity.Tonee);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Gram;
                    }
                    else if (quantity.OptionType == OptionType.GramToKilogram.ToString())
                    {
                        quantity.Kilogram = quantity.Gram * 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonee", quantity.Tonee);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Kilogram;
                    }
                    else if (quantity.OptionType == OptionType.TonneToKilogram.ToString())
                    {
                        quantity.Kilogram = quantity.Tonee * 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonee", quantity.Tonee);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Kilogram;
                    }
                    else if (quantity.OptionType == OptionType.KilogramToTonne.ToString())
                    {
                        quantity.Tonee = quantity.Kilogram / 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonee", quantity.Tonee);
                        cmd.Parameters.Add("OptionType", quantity.OptionType);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Tonee;
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public void Connection()
        {
            Console.WriteLine("Starting.\r\n");
            using (var _db = new Oracle.ManagedDataAccess.Client.OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
            {
                Console.WriteLine("Open connection...");
                _db.Open();
                Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                cmd.Connection = _db;
                cmd.CommandText =
                "begin " +
                "  execute immediate 'create table  QUANTITYMESURES.Length(Feet FLOAT(8) ,Inch FLOAT(8) ,Yard FLOAT(8) ,Centimeter FLOAT(8),OptionType varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESURES.Temperature(Fahrenheit FLOAT(8) ,Celsius FLOAT(8) ,OptionType varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESURES.Volume(Liter FLOAT(8) , Milliliter FLOAT(8) ,Gallon FLOAT(8) ,OptionType varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESURES.Weight(Kilogram FLOAT(8) ,Gram FLOAT(8) ,Tonne FLOAT(8) ,OptionType varchar2(20))';" +
               "end;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                _db.Close();
            }
        }
    }
}
