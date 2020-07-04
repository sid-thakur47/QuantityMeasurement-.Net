//-----------------------------------------------------------------------
// <copyright file="Lenght.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
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
            INCH
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
            return that.Value==Value &&  that.UnitType == UnitType;
        }

        public bool Compare(Lenght that)
        {

            if (this.UnitType.Equals(Unit.FEET) && that.UnitType.Equals(Unit.FEET) || this.UnitType.Equals(Unit.INCH) && that.UnitType.Equals(Unit.INCH))
            {
                return this.Value.CompareTo(that.Value) == 0;
            }

            if (this.UnitType.Equals(Unit.FEET) && that.UnitType.Equals(Unit.INCH))
            {
                return this.Value * FEET_TO_INCH.CompareTo(that.Value) == 0;
            }

            if (this.UnitType.Equals(Unit.INCH) && that.UnitType.Equals(Unit.FEET))
            {
                return (this.Value / FEET_TO_INCH).CompareTo(that.Value) == 0;
            }
            return false;
        }
    }
}