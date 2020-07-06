//-----------------------------------------------------------------------
// <copyright file="Lenght.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace QuantityMeasurement.BridgeLabz
{
using System;

#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    /// <summary>
    /// Lenght conversion
    /// </summary>
    public class QuantitiyMeasurement : Units
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {

        //// <summary>
        //// va;ue of unit
        //// </summary>
        public double Value;

        //// <summary>
        //// Unit to be converted
        //// </summary>
        public Unit UnitType;

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
            this.UnitType = unit;
            this.Value = value;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="obj">Object for comparing</param>
        /// <returns>Boolean after equality check</returns>
        override
       public bool Equals(object o)
        {
            if (this == o) return true;
            if (o == null) return false;
            QuantitiyMeasurement that = (QuantitiyMeasurement)o;
            return that.Value == Value && that.UnitType == UnitType;
        }

        /// <summary>
        /// To get the baseunits
        /// </summary>
        /// <param name="unit"></param>
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

        /// <summary>
        /// To convert the values of the units
        /// </summary>
        /// <param name="firstUnit"></param>
        /// <param name="secondUnit"></param>
        /// <returns>Condtion according to comparision</returns>
        public bool UnitConversion(QuantitiyMeasurement firstUnit, QuantitiyMeasurement secondUnit)
        {
            double baseUnit1 = GetUnits(firstUnit.UnitType);
            double baseUnit2 = GetUnits(secondUnit.UnitType);
            return CompareUnits(firstUnit, secondUnit, baseUnit1, baseUnit2);
        }

        /// <summary>
        /// To compare the values of the units
        /// </summary>
        /// <param name="firstUnit">First unit for comparision</param>
        /// <param name="secountUnit">Second unit for comparision</param>
        /// <param name="firstBaseUnit">First base unit</param>
        /// <param name="secondBaseUnit">Second base unit</param>
        /// <returns>Boolean condtion according to comparsion</returns>
        private bool CompareUnits(QuantitiyMeasurement firstUnit, QuantitiyMeasurement secountUnit, double firstBaseUnit, double secondBaseUnit)
        {
            return Math.Round(firstUnit.Value * firstBaseUnit).CompareTo(Math.Round(secountUnit.Value * secondBaseUnit)) == 0;
        }
        
        /// <summary>
        /// Addition of two units
        /// </summary>
        /// <param name="firstUnit"></param>
        /// <param name="secondUnit"></param>
        /// <returns>Addition of two units</returns>
        public double Addition(QuantitiyMeasurement firstUnit, QuantitiyMeasurement secondUnit)
        {
            double baseUnit1 = GetUnits(firstUnit.UnitType);
            double baseUnit2 = GetUnits(secondUnit.UnitType);
            return Math.Round(firstUnit.Value * baseUnit1) + Math.Round(secondUnit.Value * baseUnit2);
        }
    }
}