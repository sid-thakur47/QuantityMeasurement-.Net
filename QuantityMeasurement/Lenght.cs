//-----------------------------------------------------------------------
// <copyright file="Lenght.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace QuantityMeasurement.BridgeLabz
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    /// <summary>
    /// Lenght conversion
    /// </summary>
    public class Lenght
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        //// <summary>
        //// Constant for feet and inch conversion
        //// </summary>
        public const double FEET_TO_INCH = 12.0;

        /// <summary>
        /// Constant for yard and inch
        /// </summary>
        public const double YARD_TO_INCH = 36.0;

        //// <summary>
        //// va;ue of unit
        //// </summary>
        public double Value;

        //// <summary>
        //// Unit to be converted
        //// </summary>
        public Unit UnitType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lenght"/> class
        /// </summary>
        public Lenght()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lenght"/> class
        /// </summary>
        /// <param name="unit">Unit to be converted</param>
        /// <param name="value">value of unit</param>
        public Lenght(Unit unit, double value)
        {
            this.UnitType = unit;
            this.Value = value;
        }

        public enum Unit
        {
            /// <summary>
            /// comaparing feet
            /// </summary>
            FEET,

            /// <summary>
            /// comparing inch
            /// </summary>
            INCH,

            /// <summary>
            /// comparing yard
            /// </summary>
            YARD,

            /// <summary>
            /// comparing centimeter
            /// </summary>
            CMS
        };

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
            Lenght that = (Lenght)o;
            return that.Value == Value && that.UnitType == UnitType;
        }

        /// <summary>
        /// To get the baseunits of units
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
        public bool UnitConversion(Lenght firstUnit, Lenght secondUnit)
        {
            double baseUnit1 = GetUnits(firstUnit.UnitType);
            double baseUnit2 = GetUnits(secondUnit.UnitType);
            return CompareUnits(firstUnit, secondUnit, baseUnit1, baseUnit2);
        }


        private bool CompareUnits(Lenght unit1, Lenght unit2, double baseUnit1, double baseUnit2)
        {
            return Math.Round(unit1.Value * baseUnit1).CompareTo(Math.Round(unit2.Value * baseUnit2)) == 0;
        }
    }
}