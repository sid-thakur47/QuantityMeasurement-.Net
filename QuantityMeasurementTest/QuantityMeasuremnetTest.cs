//-----------------------------------------------------------------------
// <copyright file="QuantityMeasurementTest.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//------------------------------------------------------------------

namespace QuantityMeasurement.BridgeLabz
{
using NUnit.Framework;


    /// <summary>
    /// Test for Quantity Measurement
    /// </summary>
    public class QuantityMeasurementTest
    {
        Length length = new Length();

        /// <summary>
        /// Test case 1.1: Given zero feet for comparing should return true 
        /// </summary>
        [Test]
        public void GivenZeroFeet_When_ZeroFeet_ShouldReturnZero()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 0.0);
            bool equals = firstFeet.Equals(secondFeet);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case 1.2: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_Null_ShouldReturnFalse()
        {
            bool equals = Length.Equals(Length.Unit.FEET, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.3: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_SameReference_ShouldReturnTrue()
        {
            Length firstReferanceFeet = new Length();
            Length secondReferanceFeet = new Length();
            Assert.AreEqual(firstReferanceFeet, secondReferanceFeet);
        }

        /// <summary>
        /// Test case 1.4: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_Type_EqualToReturnTrue()
        {
            Length firstFeetValue = new Length(Length.Unit.FEET, 0.0);
            Length secondFeetValue = new Length(Length.Unit.FEET, 0.0);
            Assert.AreEqual(firstFeetValue.GetType(), secondFeetValue.GetType());
        }

        /// <summary>
        /// Test case 1.5: Feet with same value should return true
        /// </summary>
        [Test]
        public void GivenFeet_When_SameValue_ShouldReturnEqual()
        {
            Length firstFeetValue = new Length(Length.Unit.FEET, 10.0);
            Length secondFeetValue = new Length(Length.Unit.FEET, 10.0);
            bool equals = firstFeetValue.Equals(secondFeetValue);
            Assert.True(equals);
        }

        /// <summary>
        /// Test case 1.6: Given  Inch when zero should return true
        /// </summary>
        [Test]
        public void GivenInch_When_Zero_ShouldReturnFalse()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = new Length(Length.Unit.INCH, 0.0);
            bool equals = firstInch.Equals(secondInch);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case 1.7: Given Inch when Null should return false
        /// </summary>
        [Test]
        public void GivenInch_When_Null_ShouldReturnFalse()
        {
            bool equals = Length.Equals(Length.Unit.INCH, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.8: Given Inch with same reference  should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameReference_ShouldReturnTrue()
        {
            //Instance of Conversion
            Length firstReferanceInch = new Length();
            Length secondReferanceInch = firstReferanceInch;
            Assert.AreEqual(firstReferanceInch, secondReferanceInch);
        }

        /// <summary>
        /// Test case 1.9: Given Inch with same type should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameType_ShouldReturnTrue()
        {
            Length firstInchValue = new Length(Length.Unit.INCH, 0.0);
            Length secondInchValue = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }

        /// <summary>
        /// Test case 1.10: Given Inch with same value should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameValue_ShouldReturnTrue()
        {
            Length firstInchValue = new Length(Length.Unit.INCH, 10.0);
            Length secondInchValue = new Length(Length.Unit.INCH, 10.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }
    }
}