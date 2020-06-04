using QuantityModelLayer.Model;
using QuantityRepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QuantityRepositoryLayer.Repository
{
    public class QuantityRepository: IQuatityRepository
    {
        readonly DBContext db;
        public QuantityRepository(DBContext _db)
        {
            db = _db;
        }
        public List<Length> AllData()
        {
            return (from p in db.Unit
                    select new Length
                    {
                        Id = p.Id,
                        Feet = p.Feet,
                        Inch = p.Inch,
                        Yard = p.Yard,
                        Result = p.Result,
                        OptionType = p.OptionType
                    }).ToList();
        }
        public int Delete(int Id)
        {
            int result = 0;

            if (db != null)
            {
                var b = db.Unit.FirstOrDefault(x => x.Id == Id);

                if (b != null)
                {
                    //Delete that post
                    db.Unit.Remove(b);

                    //Commit the transaction
                    result = db.SaveChanges();
                }
                return result;

            }
            return result;
        }

        //// Volume
        public List<Volume> AllVolumeData()
        {
            return (from p in db.Volume
                    select new Volume
                    {
                        Id = p.Id,
                        Gallon = p.Gallon,
                        Litre = p.Litre,
                        Millilitre = p.Millilitre,
                        Result = p.Result,
                        OptionType = p.OptionType
                    }).ToList();
        }
        public object PostAll(object volume)
        {
            if (db != null)
            {
                db.Add(volume);
                db.SaveChanges();
                return volume;
            }
            return 0;
        }

        public int DeleteVolume(int Id)
        {
            int result = 0;

            if (db != null)
            {
                var b = db.Volume.FirstOrDefault(x => x.Id == Id);

                if (b != null)
                {
                    //Delete that post
                    db.Volume.Remove(b);

                    //Commit the transaction
                    result = db.SaveChanges();
                }
                return result;
            }
            return result;
        }

        //// Weights
        public List<Weight> AllWeightData()
        {

            return (from p in db.Weight
                    select new Weight
                    {
                        Id = p.Id,
                        Kg = p.Kg,
                        Gram = p.Gram,
                        Ton = p.Ton,
                        Result = p.Result,
                        OptionType = p.OptionType
                    }).ToList();
        }

        public int DeleteWeight(int Id)
        {
            int result = 0;

            if (db != null)
            {
                var b = db.Weight.FirstOrDefault(x => x.Id == Id);

                if (b != null)
                {
                    //Delete that post
                    db.Weight.Remove(b);

                    //Commit the transaction
                    result = db.SaveChanges();
                }
                return result;
            }
            return result;
        }

        //// Temperature
        public List<Temperature> AllTemperatureData()
        {

            return (from p in db.Temperature
                    select new Temperature
                    {
                        Id = p.Id,
                        Celsius = p.Celsius,
                        Fahrenheit = p.Fahrenheit,
                        Result = p.Result,
                        OptionType = p.OptionType
                    }).ToList();
        }

        public int DeleteTemperature(int Id)
        {
            int result = 0;

            if (db != null)
            {
                var b = db.Temperature.FirstOrDefault(x => x.Id == Id);

                if (b != null)
                {
                    //Delete that post
                    db.Temperature.Remove(b);

                    //Commit the transaction
                    result = db.SaveChanges();
                }
                return result;
            }
            return result;
        }
    }
}
