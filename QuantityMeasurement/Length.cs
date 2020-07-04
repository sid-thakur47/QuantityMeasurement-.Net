
//-----------------------------------------------------------------------
// <copyright file="Length.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------
namespace QuantityMeasurement.BridgeLabz
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Length
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
       /// <summary>
       /// Instance of Unit
       /// </summary>
       public Unit UnitType;
        /// <summary>
        /// value to be converted
        /// </summary>
       private double Value;


        /// <summary>
        /// Initializes a new instance of the <see cref="Length"/> class
        /// </summary>
        public Length()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Length"/> class
        /// </summary>
        /// <param name="unit">Unit to be converted</param>
        /// <param name="value">value of unit</param>
        public Length(Unit unit, double value)
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
        public override bool Equals(object obj)
        {
            if (obj == null)
            { 
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            Length that = (Length)obj;
            return (this.UnitType == that.UnitType) && (this.Value == that.Value) ||
                 (this.UnitType.Equals(Unit.FEET) && that.UnitType.Equals(Unit.INCH) &&
                this.Value == 0 && that.Value == 0);
        }

        /// <summary>
        /// For conversion of feet to inch
        /// </summary>
        /// <param name="valueInFeet"> value in feet</param>
        /// <returns> feet converion to inch</returns>
        public double FeetToInch(double valueInFeet)
        {
            return valueInFeet * 12;
        }

        /// <summary>
        /// For conversion of inch to feet
        /// </summary>
        /// <param name="valueInInch"> value in inch</param>
        /// <returns>inch conversion to feet</returns>
        public double InchToFeet(double valueInInch)
        {
            return valueInInch / 12;
        }
    }
}