﻿using QuantityMeasurementModel;
using QuantityMeasurementRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementManager.QuantityManager
{
    public class QuantityMeasurementManagers : IQuantityManager.IQuantityMeasurementManager
    {
        /// <summary>
        /// Calling the IQuantityRepository.
        /// </summary>
        private IQuantityRepository repo;

        /// <summary>
        /// Parametereized constructor.
        /// </summary>
        /// <param name="repo"></param>
        public QuantityMeasurementManagers(IQuantityRepository repo)
        {
            this.repo = repo;
        }

        public object LengthPost(LengthUnit value)
        {
            return this.repo.LengthPost(value);
        }
        public object VolumePost(VolumeUnit value)
        {
            return this.repo.VolumePost(value);
        }
        public object WeightPost(WeightUnit value)
        {
            return this.repo.WeightPost(value);
        }
        public object TempreturePost(TempretureUnit value)
        {
            return this.repo.TempreturePost(value);
        }
    }
}
