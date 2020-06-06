using QuantityMeasurementManager.IQuantityManager;
using QuantityMeasurementModel;
using QuantityMeasurementRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementManager.QuantityManager
{
    public class QuantityMeasurementManagers:IQuantityMeasurementManager
    {
        private IQuantityRepository repo;
        public QuantityMeasurementManagers(IQuantityRepository repo)
        {
            this.repo = repo;
        }
        public double FeetToInch(LengthUnit value)
        {
            return this.repo.FeetToInch(value);
        }
        public double InchToFeet(LengthUnit value)
        {
            return this.repo.InchToFeet(value);
        }
        public double InchToCentiMeter(LengthUnit value)
        {
            return this.repo.InchToCentiMeter(value);
        }
        public double CentiMeterToInch(LengthUnit value)
        {
            return this.repo.CentiMeterToInch(value);
        }
        public double FeetToYard(LengthUnit value)
        {
            return this.repo.FeetToYard(value);
        }
        public double YardToFeet(LengthUnit value)
        {
            return this.repo.YardToFeet(value);
        }

        public double GramToKilogram(WeightUnit value)
        {
            return this.repo.GramToKilogram(value);
        }
        public double KilogramToGram(WeightUnit value)
        {
            return this.repo.KilogramToGram(value);
        }
        public double TonneToKilogram(WeightUnit value)
        {
            return this.repo.TonneToKilogram(value);
        }
        public double KilogramToTonne(WeightUnit value)
        {
            return this.repo.KilogramToTonne(value);
        }

        public double GallonToLitre(VolumeUnit value)
        {
            return this.repo.GallonToLitre(value);
        }
        public double LitreToGallon(VolumeUnit value)
        {
            return this.repo.LitreToGallon(value);
        }
        public double LitreToMiliLitre(VolumeUnit value)
        {
            return this.repo.LitreToMiliLitre(value);
        }
        public double MiliLitreToLitre(VolumeUnit value)
        {
            return this.repo.MiliLitreToLitre(value);
        }
        public double FahrenhietToCelcius(TempretureUnit value)
        {
            return this.repo.FahrenhietToCelcius(value);
        }
        public double CelciusToFahrenhiet(TempretureUnit value)
        {
            return this.repo.CelciusToFahrenhiet(value);
        }

    }
}
