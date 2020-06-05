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
        public int DeleteLength(int Id)
        {
            int result = 0;
            if (db != null)
            {
                var b = db.Length.FirstOrDefault(x => x.Id == Id);

                if (b != null)
                {
                    db.Length.Remove(b);
                    result = db.SaveChanges();
                }
                return result;
            }
            return result;
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
        public int DeleteWeight(int Id)
        {
            int result = 0;

            if (db != null)
            {
                var b = db.Weight.FirstOrDefault(x => x.Id == Id);

                if (b != null)
                {
                    db.Weight.Remove(b);
                    result = db.SaveChanges();
                }
                return result;
            }
            return result;
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
