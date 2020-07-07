//-----------------------------------------------------------------------
// <copyright file="QuantitiyMeasurement.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace QuantityMeasurement.BridgeLabz
{
using System;

    /// <summary>
    /// Quantity Measurement
    /// </summary>
    public class QuantitiyMeasurement : Units
    {
        /// <summary>
        /// Value of unit
        /// </summary>
        private double value;

        /// <summary>
        /// Type of unit
        /// </summary>
        private Unit unitType;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantitiyMeasurement"/> class
        /// </summary>
        public QuantitiyMeasurement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantitiyMeasurement"/> class
        /// </summary>
        /// <param name="unit">Unit to be converted</param>
        /// <param name="value">value of unit</param>
        public QuantitiyMeasurement(Unit unit, double value)
        {
            this.unitType = unit;
            this.value = value;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="o">Object for comparing</param>
        /// <returns>Boolean after equality check</returns>
        override
       public bool Equals(object o)
        {
            if (this == o) 
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            QuantitiyMeasurement that = (QuantitiyMeasurement)o;
            return that.value == this.value && that.unitType == this.unitType;
        }

        /// <summary>
        /// To convert the values of the units
        /// </summary>
        /// <param name="firstUnit">First unit</param>
        /// <param name="secondUnit">Second unit</param>
        /// <returns>Condition according to comparison</returns>
        public bool UnitConversion(QuantitiyMeasurement firstUnit, QuantitiyMeasurement secondUnit)
        {
            double firstBaseUnit = this.GetUnits(firstUnit.unitType);
            double secondBaseUnit = this.GetUnits(secondUnit.unitType);
            return this.CompareUnits(firstUnit, secondUnit, firstBaseUnit, secondBaseUnit);
        }

        /// <summary>
        /// Addition of  unit
        /// </summary>
        /// <param name="firstUnit">first unit for addition</param>
        /// <param name="secondUnit">second unit for addition></param>
        /// <returns>addition of both units</returns>
        public double Addition(QuantitiyMeasurement firstUnit, QuantitiyMeasurement secondUnit)
        {
            double baseUnit1 = this.GetUnits(firstUnit.unitType);
            double baseUnit2 = this.GetUnits(secondUnit.unitType);
            return Math.Round(firstUnit.value * baseUnit1) + Math.Round(secondUnit.value * baseUnit2);
        }

        /// <summary>
        /// Temperature conversion
        /// </summary>
        /// <param name="firstTemp">first temperature for comparison </param>
        /// <param name="secondTemp">second temperature comparison</param>
        /// <returns>boolean condition according to comparison</returns>
        public bool ConvertTemperature(QuantitiyMeasurement firstTemp, QuantitiyMeasurement secondTemp)
        {
            if (firstTemp.unitType.Equals(Unit.FAHRENHEIT) && secondTemp.unitType.Equals(Unit.CELSIUS))
            {
                return ((firstTemp.value - 32) * 5 / 9).CompareTo(secondTemp.value) == 0;
            }
            else if (firstTemp.unitType.Equals(Unit.CELSIUS) && secondTemp.unitType.Equals(Unit.FAHRENHEIT))
            {
                return ((firstTemp.value * 9 / 5) + 32).CompareTo(secondTemp.value) == 0;
            }

            return false;
        }

        /// <summary>
        /// To compare the values of the units
        /// </summary>
        /// <param name="firstUnit">First unit for comparison</param>
        /// <param name="secountUnit">Second unit for comparison</param>
        /// <param name="firstBaseUnit">First base unit</param>
        /// <param name="secondBaseUnit">Second base unit</param>
        /// <returns>Boolean condition according to comparison</returns>
        private bool CompareUnits(QuantitiyMeasurement firstUnit, QuantitiyMeasurement secountUnit, double firstBaseUnit, double secondBaseUnit)
        {
            return Math.Round(firstUnit.value * firstBaseUnit).CompareTo(Math.Round(secountUnit.value * secondBaseUnit)) == 0;
        }

        /// <summary>
        /// To get the base units
        /// </summary>
        /// <param name="unit"> Unit to be converted</param>
        /// <returns> Unit values</returns>
        private double GetUnits(Unit unit)
        {
            switch (unit)
            {
                case Unit.INCH:
                    return 1;
                case Unit.FEET:
                    return 12;
                case Unit.YARD:
                    return 36;
                case Unit.CMS:
                    return 0.4;
                case Unit.GALLON:
                    return 3.78;
                case Unit.LITRE:
                    return 1;
                case Unit.MiLLILITERS:
                    return 0.001;
                case Unit.KILLOGRAM:
                    return 1;
                case Unit.GRAM:
                    return 0.001;
                case Unit.TON:
                    return 1000.0;
                default:
                    return 0;
            }
        }
    }
}