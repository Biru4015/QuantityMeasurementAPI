namespace QuantityRepositoryLayer.Repository
{
    using QuantityModelLayer.Model;
    using QuantityRepositoryLayer.IRepository;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// This is repository class
    /// </summary>
    public class QuantityRepository: IQuatityRepository
    {
        private readonly DBContext db;
        public QuantityRepository(DBContext _db)
        {
            db = _db;
        }

        /// <summary>
        /// This method is for getting all the list of length conversion
        /// </summary>
        /// <returns>list</returns>
        public List<Length> AllDataLength()
        {
            return (from p in db.Length
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

        /// <summary>
        /// This method is created for adding length conversion
        /// </summary>
        /// <param name="Length"></param>
        /// <returns></returns>
        public object PostAllLength(object Length)
        {
            if (db != null)
            {
                db.Add(Length);
                db.SaveChanges();
                return Length;
            }
            return 0;
        }

        /// <summary>
        /// This method is created for updating length conversion
        /// </summary>
        /// <param name="lengthChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateLength(Length lengthChanges)
        {
            var employee = db.Length.Attach(lengthChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = db.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// This method is created for deleting length list id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Length DeleteLength(int Id)
        {
            Length length = db.Length.Find(Id);
            if (length != null)
            {
                db.Length.Remove(length);
                db.SaveChanges();
            }
            return length;
        }

        /// <summary>
        /// This method is created for getting all the list of volume conversion
        /// </summary>
        /// <returns>list</returns>
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

        /// <summary>
        /// This method is use for posting all the conversion in volume table
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        public object PostAllVolume(object volume)
        {
            if (db != null)
            {
                db.Add(volume);
                db.SaveChanges();
                return volume;
            }
            return 0;
        }

        /// <summary>
        /// This method is created for updating volume conversion
        /// </summary>
        /// <param name="volumeChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateVolume(Volume volumeChanges)
        {
            var employee = db.Volume.Attach(volumeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = db.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// This method is created for deleting id of volume conversion
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Volume DeleteVolume(int Id)
        {
            Volume volume = db.Volume.Find(Id);
            if (volume != null)
            {
                db.Volume.Remove(volume);
                db.SaveChanges();
            }
            return volume;
        }

        /// <summary>
        /// This method is created for getting ist of weight
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// This method is created for adding weight conversion
        /// </summary>
        /// <param name="Weight"></param>
        /// <returns></returns>
        public object PostAllWeight(object Weight)
        {
            if (db != null)
            {
                db.Add(Weight);
                db.SaveChanges();
                return Weight;
            }
            return 0;
        }

        /// <summary>
        /// This method is created for updating weight conversion
        /// </summary>
        /// <param name="weightChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateWeight(Weight weightChanges)
        {
            var employee = db.Weight.Attach(weightChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = db.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// This method is created for deleting id of weight
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Weight DeleteWeight(int Id)
        {
            Weight weight = db.Weight.Find(Id);
            if (weight != null)
            {
                db.Weight.Remove(weight);
                db.SaveChanges();
            }
            return weight;
        }

        /// <summary>
        /// This method is created for getting all the list of tempreture table
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// This method is created for adding tempreture conversion
        /// </summary>
        /// <param name="Temperature"></param>
        /// <returns></returns>
        public object PostAllTempreture(object Temperature)
        {
            if (db != null)
            {
                db.Add(Temperature);
                db.SaveChanges();
                return Temperature;
            }
            return 0;
        }

        /// <summary>
        /// This method is created for updating tempreture conversion
        /// </summary>
        /// <param name="tempretureChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateTempreture(Temperature tempretureChanges)
        {
            var employee = db.Temperature.Attach(tempretureChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = db.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// This method is created for deleting id of tempreture table
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Temperature DeleteTemperature(int Id)
        {
            Temperature temperature = db.Temperature.Find(Id);
            if (temperature != null)
            {
                db.Temperature.Remove(temperature);
                db.SaveChanges();
            }
            return temperature;
        }
    }
}
