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

        Lenght lenght = null;
        [SetUp]
        public void Setup()
        {
            lenght = new Lenght();
        }

        /// <summary>
        /// Test case 1.1: Given zero feet for comparing should return true 
        /// </summary>
        [Test]
        public void GivenZeroFeet_When_ZeroFeet_ShouldReturnZero()
        {
            Lenght firstFeet = new Lenght(Lenght.Unit.FEET, 0.0);
            Lenght secondFeet = new Lenght(Lenght.Unit.FEET, 0.0);
            bool equals = firstFeet.Equals(secondFeet);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case 1.2: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_Null_ShouldReturnFalse()
        {
            bool equals = Lenght.Equals(Lenght.Unit.FEET, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.3: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_SameReference_ShouldReturnTrue()
        {
            Lenght firstReferanceFeet = new Lenght();
            Lenght secondReferanceFeet = new Lenght();
            Assert.AreEqual(firstReferanceFeet, secondReferanceFeet);
        }

        /// <summary>
        /// Test case 1.4: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_Type_EqualToReturnTrue()
        {
            Lenght firstFeetValue = new Lenght(Lenght.Unit.FEET, 0.0);
            Lenght secondFeetValue = new Lenght(Lenght.Unit.FEET, 0.0);
            Assert.AreEqual(firstFeetValue.GetType(), secondFeetValue.GetType());
        }

        /// <summary>
        /// Test case 1.5: Feet with same value should return true
        /// </summary>
        [Test]
        public void GivenFeet_When_SameValue_ShouldReturnEqual()
        {
            Lenght firstFeetValue = new Lenght(Lenght.Unit.FEET, 10.0);
            Lenght secondFeetValue = new Lenght(Lenght.Unit.FEET, 10.0);
            bool equals = firstFeetValue.Equals(secondFeetValue);
            Assert.True(equals);
        }

        /// <summary>
        /// Test case 1.6: Given  Inch when zero should return true
        /// </summary>
        [Test]
        public void GivenInch_When_Zero_ShouldReturnFalse()
        {
            Lenght firstInch = new Lenght(Lenght.Unit.INCH, 0.0);
            Lenght secondInch = new Lenght(Lenght.Unit.INCH, 0.0);
            bool equals = firstInch.Equals(secondInch);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case 1.7: Given Inch when Null should return false
        /// </summary>
        [Test]
        public void GivenInch_When_Null_ShouldReturnFalse()
        {
            bool equals = Lenght.Equals(Lenght.Unit.INCH, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.8: Given Inch with same reference  should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameReference_ShouldReturnTrue()
        {
            //Instance of Conversion
            Lenght firstReferanceInch = new Lenght();
            Lenght secondReferanceInch = firstReferanceInch;
            Assert.AreEqual(firstReferanceInch, secondReferanceInch);
        }

        /// <summary>
        /// Test case 1.9: Given Inch with same type should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameType_ShouldReturnTrue()
        {
            Lenght firstInchValue = new Lenght(Lenght.Unit.INCH, 0.0);
            Lenght secondInchValue = new Lenght(Lenght.Unit.INCH, 0.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }

        /// <summary>
        /// Test case 1.10: Given Inch with same value should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameValue_ShouldReturnTrue()
        {
            Lenght firstInchValue = new Lenght(Lenght.Unit.INCH, 10.0);
            Lenght secondInchValue = new Lenght(Lenght.Unit.INCH, 10.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }

        /// <summary>
        /// Test case 1.11: Given 0 inch and 0 feet should return zero
        /// </summary>
        [Test]
        public void Given_ZeroFeetAndZeroInch_When_ShouldReturnEqual()
        {
            Lenght firstFeet = new Lenght(Lenght.Unit.FEET, 0.0);
            Lenght secondFeet = new Lenght(Lenght.Unit.INCH, 0.0);
            Assert.IsTrue(lenght.UnitConversion(firstFeet,secondFeet));
        }

        /// <summary>
        /// Test case 1.12: Given 1 feet and 1 inch should not be equal
        /// </summary>
        [Test]
        public void Given_OneFeetAndOneInch_When_UnitConversiond_ShouldReturnFalse()
        {
            Lenght feet1 = new Lenght(Lenght.Unit.FEET, 1.0);
            Lenght inch1 = new Lenght(Lenght.Unit.INCH, 1.0);
            Assert.AreNotEqual(feet1, inch1);
        }

        //// <summary>
        //// Test case 1.13: Given 1 inch and 2 inch  should return false
        //// </summary>
        [Test]
        public void Given_OneInchAndOneInch_When_UnitConversiond_ShouldReturnFalse()
        {
            Lenght inch1 = new Lenght(Lenght.Unit.INCH, 1.0);
            Lenght inch2 = new Lenght(Lenght.Unit.INCH, 2.0);
            bool compare = lenght.UnitConversion(inch1,inch2);
            Assert.IsFalse(compare);
        }
        //// <summary>
        //// Test case 1.14: Given 1 feet and 12 inch when converted should return true
        //// </summary
        [Test]
        public void Given_FeetAndInch_When_UnitConversiond_ShouldReturnTrue()
        {
            Lenght feet = new Lenght(Lenght.Unit.FEET, 1.0);
            Lenght inch = new Lenght(Lenght.Unit.INCH, 12.0);
            bool compare = lenght.UnitConversion(feet,inch);
            Assert.IsTrue(compare);
        }
        //// <summary>
        //// Test case 1.15 Given 12 inch and 1Feet when UnitConversiond should return treu
        //// </summary
        [Test]
        public void Given_12InchAnd1Feet_When_UnitConversiond_ShouldReturnTrue()
        {
            Lenght inch = new Lenght(Lenght.Unit.INCH, 12.0);
            Lenght feet = new Lenght(Lenght.Unit.FEET, 1.0);
            bool compare = lenght.UnitConversion(inch,feet);
            Assert.IsTrue(compare);
        }

        //// <summary>
        //// Test case  2.1:Given yard and feet when converted and compared should return true
        //// </summary
        [Test]
        public void Given_OneYardAndThreeFeet_When_UnitConversiond_ShouldReturnTrue()
        {
            Lenght yard = new Lenght(Lenght.Unit.YARD, 1.0);
            Lenght feet = new Lenght(Lenght.Unit.FEET, 3.0);
            bool compare = lenght.UnitConversion(yard,feet);
            Assert.IsTrue(compare);
        }

        //// <summary>
        //// Test case 2.2: Given 1 yard and 1 feet when compared returns false
        //// </summary
        [Test]
        public void Given_OneFeetAndOneYard_When_UnitConversiond_ShouldReturnFalse()
        {
            Lenght feet = new Lenght(Lenght.Unit.FEET, 1.0);
            Lenght yard = new Lenght(Lenght.Unit.YARD, 1.0);
            bool compareCheck = lenght.UnitConversion(feet,yard);
            Assert.IsFalse(compareCheck);
        }

        [Test]
        //// <summary>
        //// Test case 2.3: Given 1 yard and 36 inch when compared returns true
        //// </summary
        public void Given_OneYardAnd36Inch_When_UnitConversiond_ShouldReturnEqualLength()
        {
            Lenght yard = new Lenght(Lenght.Unit.YARD, 1.0);
            Lenght inch = new Lenght(Lenght.Unit.INCH, 36.0);
            bool compareCheck = lenght.UnitConversion(yard,inch);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case 2.4: Given 36 inch and 1 yard when compared returns true
        //// </summary
        [Test]
        public void Given_36InchAnd1yard_When_UnitConversiond_ShouldReturnEqualLength()
        {
            Lenght inch = new Lenght(Lenght.Unit.INCH, 36.0);
            Lenght yard = new Lenght(Lenght.Unit.YARD, 1.0);
            bool compareCheck = lenght.UnitConversion(inch,yard);
            Assert.IsTrue(compareCheck);
        }

        //// <summary>
        //// Test case 2.5: Given 3 feet and 1 yard when compared should return true
        //// </summary
        [Test]
        public void Given_3FeetAnd1Yard_WhenUnitConversiond_ShouldReturnTrue()
        {
            Lenght yard = new Lenght(Lenght.Unit.YARD, 1.0);
            Lenght feet = new Lenght(Lenght.Unit.FEET, 3.0);
            bool compareCheck = lenght.UnitConversion(yard,feet);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Test case 3 : Given 2 inch and 5 cm when compared should return true
        /// </summary>
        [Test]
        public void Given2InchAnd5Cms_WhenCompared_ShouldReturnTrue()
        {
            Lenght inch1 = new Lenght(Lenght.Unit.INCH, 2.0);
            Lenght cms1 = new Lenght(Lenght.Unit.CMS, 5.0);
            bool compareCheck = lenght.UnitConversion(inch1, cms1);
            Assert.IsTrue(compareCheck);
        }
    }
}