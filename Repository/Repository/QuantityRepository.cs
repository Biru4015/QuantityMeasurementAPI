namespace QuantityMeasurementRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using Microsoft.Extensions.Configuration;
    using Oracle.ManagedDataAccess.Client;
    using QuantityMeasurementModel;
    using QuantityMeasurementRepository;
    using QuantityMeasurementRepository.IRepository;

    /// <summary>
    /// This class contains the code of repository.
    /// </summary>
    public class QuantityRepository:IQuantityRepository
    {
        private readonly IConfiguration configuration;
        public QuantityRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public object LengthPost(LengthUnit quantity)
        {
            try
            {
                var commandText = Queries.insertLengthQuery;
                using (var _db = new OracleConnection(configuration["ConnectionStrings:UserDbConnection"]))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    object result;
                    switch(quantity.LengthOptions)
                    {
                        case "FeetToInch":
                            quantity.Inch = quantity.Feet * 12;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Feet", quantity.Feet);
                                cmd.Parameters.Add("Inch", quantity.Inch);
                                cmd.Parameters.Add("Yard", quantity.Yard);
                                cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                                cmd.Parameters.Add("LengthOptions", quantity.LengthOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Inch;
                            break;
                        case "InchToFeet":
                            quantity.Feet = quantity.Inch / 12;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Feet", quantity.Feet);
                                cmd.Parameters.Add("Inch", quantity.Inch);
                                cmd.Parameters.Add("Yard", quantity.Yard);
                                cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                                cmd.Parameters.Add("LengthOptions", quantity.LengthOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Feet;
                            break;
                        case "FeetToYard":
                            quantity.Yard = quantity.Feet / 3;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Feet", quantity.Feet);
                                cmd.Parameters.Add("Inch", quantity.Inch);
                                cmd.Parameters.Add("Yard", quantity.Yard);
                                cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                                cmd.Parameters.Add("LengthOptions", quantity.LengthOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Feet;
                            break;
                        case "YardToFeet":
                            quantity.Feet = quantity.Yard * 3;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Feet", quantity.Feet);
                                cmd.Parameters.Add("Inch", quantity.Inch);
                                cmd.Parameters.Add("Yard", quantity.Yard);
                                cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                                cmd.Parameters.Add("LengthOptions", quantity.LengthOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Yard;
                            break;
                        case "CentiMeterToInch":
                            quantity.Inch = quantity.Centimeter / 2.54;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Feet", quantity.Feet);
                                cmd.Parameters.Add("Inch", quantity.Inch);
                                cmd.Parameters.Add("Yard", quantity.Yard);
                                cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                                cmd.Parameters.Add("OptionType", quantity.LengthOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Inch;
                            break;
                        case "InchToCentiMeter":
                            quantity.Centimeter = quantity.Inch * 2.54;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Feet", quantity.Feet);
                                cmd.Parameters.Add("Inch", quantity.Inch);
                                cmd.Parameters.Add("Yard", quantity.Yard);
                                cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                                cmd.Parameters.Add("LengthOptions", quantity.LengthOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Centimeter;
                            break;
                        default:
                            result= new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                            break;
                    }
                    return result;
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
                var commandText = Queries.insertTempretureQuery;
                using (var _db = new OracleConnection(configuration["ConnectionStrings:UserDbConnection"]))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    
                     object result;
                    switch(quantity.TempretureOptions)
                    {
                        case "FahrenhietToCelcius":
                            quantity.Celcius = ((quantity.Fahrenhiet - 32) * 5 / 9);
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("fahrenhiet", quantity.Fahrenhiet);
                                cmd.Parameters.Add("celcius", quantity.Celcius);
                                cmd.Parameters.Add("TempretureOptions", quantity.TempretureOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Celcius;
                            break;
                        case "CelciusToFahrenhiet":
                            quantity.Fahrenhiet = ((quantity.Celcius * 9 / 5) + 32);
                                cmd.Connection = _db;
                            cmd.Parameters.Add("Id", quantity.Id);
                            cmd.Parameters.Add("fahrenhiet", quantity.Fahrenhiet);
                                cmd.Parameters.Add("celcius", quantity.Celcius);
                                cmd.Parameters.Add("TempretureOptions", quantity.TempretureOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Fahrenhiet;
                            break;
                        default:
                            result= new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                            break;
                    }
                    return result;
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
                var commandText = Queries.insertVolumeQuery;
                using (var _db = new OracleConnection(configuration["ConnectionStrings:UserDbConnection"]))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    object result;
                    switch(quantity.VolumeOptions)
                    {
                        case "MiliLitreToLitre":
                            quantity.Litre = quantity.Mililitre / 1000;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("litre", quantity.Litre);
                                cmd.Parameters.Add("milimeter", quantity.Mililitre);
                                cmd.Parameters.Add("Gallon", quantity.Gallon);
                                cmd.Parameters.Add("VolumeOptions", quantity.VolumeOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                               _db.Close();
                                result= quantity.Litre;
                            break;
                        case "LitreToMililitre":
                            quantity.Mililitre = quantity.Litre * 1000;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("litre", quantity.Litre);
                                cmd.Parameters.Add("milimeter", quantity.Mililitre);
                                cmd.Parameters.Add("Gallon", quantity.Gallon);
                                cmd.Parameters.Add("VolumeOptions", quantity.VolumeOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Mililitre;
                            break;
                        case "LitreToGallon":
                            quantity.Gallon = quantity.Litre / 3.785;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("litre", quantity.Litre);
                                cmd.Parameters.Add("milimeter", quantity.Mililitre);
                                cmd.Parameters.Add("Gallon", quantity.Gallon);
                                cmd.Parameters.Add("VolumeOptions", quantity.VolumeOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Gallon;
                            break;
                        case "GallonToLitre":
                            quantity.Litre = quantity.Gallon * 3.785;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("litre", quantity.Litre);
                                cmd.Parameters.Add("milimeter", quantity.Mililitre);
                                cmd.Parameters.Add("Gallon", quantity.Gallon);
                                cmd.Parameters.Add("VolumeOptions", quantity.VolumeOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Litre;
                            break;

                        default:
                            result= new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                            break;
                    }
                    return result;
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
                var commandText = Queries.inserWeightQuery;
                using (var _db = new OracleConnection(configuration["ConnectionStrings:UserDbConnection"]))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    object result;
                    switch(quantity.WeightOptions)
                    {
                        case "KilogramToGram":
                            quantity.Gram = quantity.Kilogram * 1000;
                                cmd.Connection = _db;
                            cmd.Parameters.Add("Id", quantity.Id);
                            cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                                cmd.Parameters.Add("Gram", quantity.Gram);
                                cmd.Parameters.Add("Tonee", quantity.Tonne);
                                cmd.Parameters.Add("WeightOptions", quantity.WeightOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                               _db.Close();
                                result= quantity.Gram;
                            break;
                        case "GramToKilogram":
                            quantity.Kilogram = quantity.Gram / 1000;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                                cmd.Parameters.Add("Gram", quantity.Gram);
                                cmd.Parameters.Add("Tonee", quantity.Tonne);
                                cmd.Parameters.Add("WeightOptions", quantity.WeightOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Kilogram;
                            break;
                        case "TonneToKilogram":
                            quantity.Kilogram = quantity.Tonne * 1000;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                                cmd.Parameters.Add("Gram", quantity.Gram);
                                cmd.Parameters.Add("Tonee", quantity.Tonne);
                                cmd.Parameters.Add("WeightOptions", quantity.WeightOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Kilogram;
                            break;
                        case "KilogramToTonne":
                            quantity.Tonne = quantity.Kilogram / 1000;
                                cmd.Connection = _db;
                                cmd.Parameters.Add("Id", quantity.Id);
                                cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                                cmd.Parameters.Add("Gram", quantity.Gram);
                                cmd.Parameters.Add("Tonne", quantity.Tonne);
                                cmd.Parameters.Add("WeightOptions", quantity.WeightOptions);
                                _db.Open();
                                cmd.ExecuteNonQuery();
                                _db.Close();
                                result= quantity.Tonne;
                            break;
                        default:
                            result= new CustomException(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                            break;
                    }
                    return result;
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
            using (var _db = new OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
            {
                Console.WriteLine("Open connection...");
                _db.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = _db;
                cmd.CommandText =
                "begin " +
                "  execute immediate 'create table  QUANTITYMESUREMENT.Length(Id Integer Primary Key,Feet FLOAT(8) ,Inch FLOAT(8) ,Yard FLOAT(8) ,Centimeter FLOAT(8),OptionType varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESUREMENT.Temperature(Id Integer Primary Key,Fahrenheit FLOAT(8) ,Celsius FLOAT(8) ,OptionType varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESUREMENT.Volume(Id Integer Primary Key,Liter FLOAT(8) , Milliliter FLOAT(8) ,Gallon FLOAT(8) ,OptionType varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESUREMENT.Weight(Id Integer Primary Key,Kilogram FLOAT(8) ,Gram FLOAT(8) ,Tonne FLOAT(8) ,OptionType varchar2(20))';" +
               "end;";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                _db.Close();
            }
        }
    }
}