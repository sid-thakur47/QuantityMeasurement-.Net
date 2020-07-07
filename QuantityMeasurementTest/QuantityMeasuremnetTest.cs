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
    public class QuantityMeasurementTest : Units
    {
        /// <summary>
        /// Instance of length
        /// </summary>
       private QuantitiyMeasurement measurement = null;

        /// <summary>
        /// setup method
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.measurement = new QuantitiyMeasurement();
        }

        /// <summary>
        /// Test case 1.1: Given zero feet for comparing should return true 
        /// </summary>
        [Test]
        public void GivenZeroFeet_When_ZeroFeet_ShouldReturnZero()
        {
            QuantitiyMeasurement firstFeet = new QuantitiyMeasurement(Unit.FEET, 0.0);
            QuantitiyMeasurement secondFeet = new QuantitiyMeasurement(Unit.FEET, 0.0);
            bool equals = firstFeet.Equals(secondFeet);
            Assert.IsTrue(equals);
        }

        /// <summary>h
        /// Test case 1.2: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_Null_ShouldReturnFalse()
        {
            bool equals = Equals(Unit.FEET, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.3: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_SameReference_ShouldReturnTrue()
        {
            QuantitiyMeasurement firstReferanceFeet = new QuantitiyMeasurement();
            QuantitiyMeasurement secondReferanceFeet = new QuantitiyMeasurement();
            Assert.AreEqual(firstReferanceFeet, secondReferanceFeet);
        }

        /// <summary>
        /// Test case 1.4: Given Null feet should return false
        /// </summary>
        [Test]
        public void GivenFeet_When_Type_EqualToReturnTrue()
        {
            QuantitiyMeasurement firstFeetValue = new QuantitiyMeasurement(Unit.FEET, 0.0);
            QuantitiyMeasurement secondFeetValue = new QuantitiyMeasurement(Unit.FEET, 0.0);
            Assert.AreEqual(firstFeetValue.GetType(), secondFeetValue.GetType());
        }

        /// <summary>
        /// Test case 1.5: Feet with same value should return true
        /// </summary>
        [Test]
        public void GivenFeet_When_SameValue_ShouldReturnEqual()
        {
            QuantitiyMeasurement firstFeetValue = new QuantitiyMeasurement(Unit.FEET, 10.0);
            QuantitiyMeasurement secondFeetValue = new QuantitiyMeasurement(Unit.FEET, 10.0);
            bool equals = firstFeetValue.Equals(secondFeetValue);
            Assert.True(equals);
        }

        /// <summary>
        /// Test case 1.6: Given  Inch when zero should return true
        /// </summary>
        [Test]
        public void GivenInch_When_Zero_ShouldReturnFalse()
        {
            QuantitiyMeasurement firstInch = new QuantitiyMeasurement(Unit.INCH, 0.0);
            QuantitiyMeasurement secondInch = new QuantitiyMeasurement(Unit.INCH, 0.0);
            bool equals = firstInch.Equals(secondInch);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case 1.7: Given Inch when Null should return false
        /// </summary>
        [Test]
        public void GivenInch_When_Null_ShouldReturnFalse()
        {
            bool equals = Equals(Unit.INCH, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.8: Given Inch with same reference  should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameReference_ShouldReturnTrue()
        {
            QuantitiyMeasurement firstReferanceInch = new QuantitiyMeasurement();
            QuantitiyMeasurement secondReferanceInch = firstReferanceInch;
            Assert.AreEqual(firstReferanceInch, secondReferanceInch);
        }

        /// <summary>
        /// Test case 1.9: Given Inch with same type should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameType_ShouldReturnTrue()
        {
            QuantitiyMeasurement firstInchValue = new QuantitiyMeasurement(Unit.INCH, 0.0);
            QuantitiyMeasurement secondInchValue = new QuantitiyMeasurement(Unit.INCH, 0.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }

        /// <summary>
        /// Test case 1.10: Given Inch with same value should return true
        /// </summary>
        [Test]
        public void GivenInch_When_SameValue_ShouldReturnTrue()
        {
            QuantitiyMeasurement firstInchValue = new QuantitiyMeasurement(Unit.INCH, 10.0);
            QuantitiyMeasurement secondInchValue = new QuantitiyMeasurement(Unit.INCH, 10.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }

        /// <summary>
        /// Test case 1.11: Given 0 inch and 0 feet should return zero
        /// </summary>
        [Test]
        public void Given_ZeroFeetAndZeroInch_When_ShouldReturnEqual()
        {
            QuantitiyMeasurement firstFeet = new QuantitiyMeasurement(Unit.FEET, 0.0);
            QuantitiyMeasurement secondFeet = new QuantitiyMeasurement(Unit.INCH, 0.0);
            Assert.IsTrue(this.measurement.UnitConversion(firstFeet, secondFeet));
        }

        /// <summary>
        /// Test case 1.12: Given 1 feet and 1 inch should not be equal
        /// </summary>
        [Test]
        public void Given_OneFeetAndOneInch_When_UnitConversiond_ShouldReturnFalse()
        {
            QuantitiyMeasurement feet1 = new QuantitiyMeasurement(Unit.FEET, 1.0);
            QuantitiyMeasurement inch1 = new QuantitiyMeasurement(Unit.INCH, 1.0);
            Assert.AreNotEqual(feet1, inch1);
        }

        /// <summary>
        /// Test case 1.13: Given 1 inch and 2 inch  should return false
        /// </summary>
        [Test]
        public void Given_OneInchAndOneInch_When_UnitConversiond_ShouldReturnFalse()
        {
            QuantitiyMeasurement inch1 = new QuantitiyMeasurement(Unit.INCH, 1.0);
            QuantitiyMeasurement inch2 = new QuantitiyMeasurement(Unit.INCH, 2.0);
            bool compare = this.measurement.UnitConversion(inch1, inch2);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 1.14: Given 1 feet and 12 inch when converted should return true
        /// </summary>
        [Test]
        public void Given_FeetAndInch_When_UnitConversiond_ShouldReturnTrue()
        {
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, 1.0);
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 12.0);
            bool compare = this.measurement.UnitConversion(feet, inch);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case 1.15 Given 12 inch and 1Feet when converted should return true
        /// </summary>
        [Test]
        public void Given_12InchAnd1Feet_When_UnitConversiond_ShouldReturnTrue()
        {
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 12.0);
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, 1.0);
            bool compare = this.measurement.UnitConversion(inch, feet);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case  2.1:Given yard and feet when converted and compared should return true
        /// </summary>
        [Test]
        public void Given_OneYardAndThreeFeet_When_UnitConversiond_ShouldReturnTrue()
        {
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, 1.0);
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, 3.0);
            bool compare = this.measurement.UnitConversion(yard, feet);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case  Negative:Given negative yard and feet when converted and compared should return false
        /// </summary>
        [Test]
        public void Given_OneYardAndMinus1Feet_When_Compared_ShouldReturnTrue()
        {
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, -1.0);
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, 3.0);
            bool compare = this.measurement.UnitConversion(yard, feet);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 2.2: Given 1 yard and 1 feet when compared returns false
        /// </summary>
        [Test]
        public void Given_OneFeetAndOneYard_When_UnitConversiond_ShouldReturnFalse()
        {
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, 1.0);
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, 1.0);
            bool compare = this.measurement.UnitConversion(feet, yard);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 2.3: Given 1 yard and 36 inch when compared returns true
        /// </summary>
        public void Given_OneYardAnd36Inch_When_UnitConversiond_ShouldReturnEqualLength()
        {
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, 1.0);
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 36.0);
            bool compare = this.measurement.UnitConversion(yard, inch);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case Negative: Given 1 yard and 36 inch when compared returns true
        /// </summary>
        public void Given_OneNeagtiveYardAnd36Inch_When_UnitConversiond_ShouldReturnEqualLength()
        {
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, -1.0);
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 36.0);
            bool compare = this.measurement.UnitConversion(yard, inch);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 2.4: Given 36 inch and 1 yard when compared returns true
        /// </summary>
        [Test]
        public void Given_36InchAnd1yard_When_UnitConversiond_ShouldReturnEqualLength()
        {
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 36.0);
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, 1.0);
            bool compare = this.measurement.UnitConversion(inch, yard);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case 2.5: Given 3 feet and 1 yard when compared should return true
        /// </summary>
        [Test]
        public void Given_3FeetAnd1Yard_WhenUnitConversiond_ShouldReturnTrue()
        {
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, 1.0);
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, 3.0);
            bool compare = this.measurement.UnitConversion(yard, feet);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case Negative: Given  feet negative and 1 yard when compared should return true
        /// </summary>
        [Test]
        public void Given_3NegativeFeetAnd1Yard_WhenUnitConversiond_ShouldReturnTrue()
        {
            QuantitiyMeasurement yard = new QuantitiyMeasurement(Unit.YARD, 1.0);
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, -3.0);
            bool compare = this.measurement.UnitConversion(yard, feet);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 3: Given 2 inch and 5 cm when compared should return true
        /// </summary>
        [Test]
        public void Given_2InchAnd5Cms_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 2.0);
            QuantitiyMeasurement cm = new QuantitiyMeasurement(Unit.CMS, 5.0);
            bool compare = this.measurement.UnitConversion(inch, cm);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case Neagtive: Given Negative inch and 5 cm when compared should return true
        /// </summary>
        [Test]
        public void Given_Negative2InchAnd5Cms_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, -2.0);
            QuantitiyMeasurement cm = new QuantitiyMeasurement(Unit.CMS, 5.0);
            bool compare = this.measurement.UnitConversion(inch, cm);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 3.1: 5 inch and 5 Cm when compared should return False
        /// </summary>
        [Test]
        public void Given_1InchAnd1Cms_WhenCompared_ShouldReturnFalse()
        {
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 5.0);
            QuantitiyMeasurement cm = new QuantitiyMeasurement(Unit.CMS, 5.0);
            bool compare = this.measurement.UnitConversion(inch, cm);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 4.1: Addition of 2 inch and 2 inch should return 4 inch
        /// </summary>
        [Test]
        public void Given2InchAnd2Inch_WhenAdded_ShouldReturn4Inch()
        {
            QuantitiyMeasurement inch1 = new QuantitiyMeasurement(Unit.INCH, 2.0);
            QuantitiyMeasurement inch2 = new QuantitiyMeasurement(Unit.INCH, 2.0);
            double addition = this.measurement.Addition(inch1, inch2);
            Assert.AreEqual(4, addition);
        }

        /// <summary>
        /// Test case 4.2: Addition of 1 feet and 2 inches which should return 14 inch
        /// </summary>
        [Test]
        public void Given_1FeetAnd2Inches_WhenAdded_ShouldReturn14Inch()
        {
            QuantitiyMeasurement feet = new QuantitiyMeasurement(Unit.FEET, 1.0);
            QuantitiyMeasurement inch = new QuantitiyMeasurement(Unit.INCH, 2.0);
            double addition = this.measurement.Addition(feet, inch);
            Assert.AreEqual(14, addition);
        }

        /// <summary>
        /// Test case 4.3: Addition of 1 feet and 1 feet which should return 24 inch
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenAdded_ShouldReturn24Inch()
        {
            QuantitiyMeasurement feet1 = new QuantitiyMeasurement(Unit.FEET, 1.0);
            QuantitiyMeasurement feet2 = new QuantitiyMeasurement(Unit.FEET, 1.0);
            double addition = this.measurement.Addition(feet1, feet2);
            Assert.AreEqual(24, addition);
        }

        /// <summary>
        /// Test case 4.4: Addition of 2 inches and 2.5 cm which should return 3 inch
        /// </summary>
        [Test]
        public void Given_1InchAnd2AndHalfCMS_WhenAdded_ShouldReturn3Inch()
        {
            QuantitiyMeasurement inch1 = new QuantitiyMeasurement(Unit.INCH, 2.0);
            QuantitiyMeasurement cms2 = new QuantitiyMeasurement(Unit.CMS, 2.5);
            double addition = this.measurement.Addition(inch1, cms2);
            Assert.AreEqual(3, addition);
        }

        /// <summary>
        /// Test case 5.1: Given gallon 1 and 3.78 liter when compared should return true
        /// </summary>
        [Test]
        public void Given_1GallonAnd3Point78Litres_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement gallon = new QuantitiyMeasurement(Unit.GALLON, 1.0);
            QuantitiyMeasurement litre = new QuantitiyMeasurement(Unit.LITRE, 3.78);
            bool compare = this.measurement.UnitConversion(gallon, litre);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case 5.2: Given 1 liter and 1000ml when compared should return true
        /// </summary>
        [Test]
        public void Given_1LitreAnd1000Ml_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement litre = new QuantitiyMeasurement(Unit.LITRE, 1.0);
            QuantitiyMeasurement milliliter = new QuantitiyMeasurement(Unit.MiLLILITERS, 1000.0);
            bool compare = this.measurement.UnitConversion(litre, milliliter);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case 5.3: Given 1 liter and 1 milliliter when compared should return false
        /// </summary>
        [Test]
        public void Given_1LitreAnd1Milliliter_WhenCompared_ShouldReturnFalse()
        {
            QuantitiyMeasurement litre = new QuantitiyMeasurement(Unit.LITRE, 1);
            QuantitiyMeasurement milliLiter = new QuantitiyMeasurement(Unit.MiLLILITERS, 1);
            bool compare = this.measurement.UnitConversion(litre, milliLiter);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 5.4: Given 1 gallon and 1 liter when compared should return false
        /// </summary>
        [Test]
        public void Given_1GallonAnd1Litre_WhenCompared_ShouldReturnFalse()
        {
            QuantitiyMeasurement gallon = new QuantitiyMeasurement(Unit.GALLON, 1);
            QuantitiyMeasurement litre = new QuantitiyMeasurement(Unit.LITRE, 1);
            bool compare = this.measurement.UnitConversion(gallon, litre);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case Negative: Given Negative liter and 1000ml when compared should return true
        /// </summary>
        [Test]
        public void Given_Negative1LitreAnd1000Ml_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement litre = new QuantitiyMeasurement(Unit.LITRE, -1.0);
            QuantitiyMeasurement milliliter = new QuantitiyMeasurement(Unit.MiLLILITERS, 1000.0);
            bool compare = this.measurement.UnitConversion(litre, milliliter);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 6.1 :Given 1 Gallon and 3.78 liters should return 7.56 Liters
        /// </summary>
        [Test]
        public void Given_1GallonAnd3point78Litres_WhenAdded_ShouldReturn7point56Inch()
        {
            QuantitiyMeasurement gallon = new QuantitiyMeasurement(Unit.GALLON, 1.0);
            QuantitiyMeasurement litre = new QuantitiyMeasurement(Unit.LITRE, 3.78);
            double addition = this.measurement.Addition(gallon, litre);
            Assert.AreEqual(8.0, addition);
        }

        /// <summary>
        /// Test case 6.2 :Given 1 liter and 3.78 milliliter should return 2 Liters
        /// </summary>
        [Test]
        public void Given_1LitreAnd1000Ml_WhenAdded_ShouldReturn2Litres()
        {
            QuantitiyMeasurement litre = new QuantitiyMeasurement(QuantitiyMeasurement.Unit.LITRE, 1.0);
            QuantitiyMeasurement milliliter = new QuantitiyMeasurement(QuantitiyMeasurement.Unit.MiLLILITERS, 1000.0);
            double addition = this.measurement.Addition(litre, milliliter);
            Assert.AreEqual(2.0, addition);
        }

        /// <summary>
        /// Test case 7.1 :Given 1 Kg and 1000 grams when compared should return True
        /// </summary>
        [Test]
        public void Given_1KgAnd1000Grams_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement killogram = new QuantitiyMeasurement(Unit.KILLOGRAM, 1.0);
            QuantitiyMeasurement gram = new QuantitiyMeasurement(Unit.GRAM, 1000.0);
            bool compare = this.measurement.UnitConversion(killogram, gram);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case 7.2 :Given 1 Ton and 1000 Kilogram when compared should return True
        /// </summary>
        [Test]
        public void Given1TonAnd1000Kgs_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement tonne = new QuantitiyMeasurement(Unit.TON, 1.0);
            QuantitiyMeasurement killogram = new QuantitiyMeasurement(Unit.KILLOGRAM, 1000.0);
            bool compare = this.measurement.UnitConversion(tonne, killogram);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case 7.3 :Addition of 1 Ton and 1000 Gram should return 1001 kilogram
        /// </summary>
        [Test]
        public void Given_1TonAnd1000Grams_WhenAdded_ShouldReturn1001Kgs()
        {
            QuantitiyMeasurement tonne = new QuantitiyMeasurement(Unit.TON, 1.0);
            QuantitiyMeasurement gram = new QuantitiyMeasurement(Unit.GRAM, 1000.0);
            double addition = this.measurement.Addition(tonne, gram);
            Assert.AreEqual(1001.0, addition);
        }

        /// <summary>
        /// Test case Negative :Given Negative 1 Kg and 1000 grams when compared should return True
        /// </summary>
        [Test]
        public void Given_Negative1KgAnd1000Grams_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement killogram = new QuantitiyMeasurement(Unit.KILLOGRAM, -1.0);
            QuantitiyMeasurement gram = new QuantitiyMeasurement(Unit.GRAM, 1000.0);
            bool compare = this.measurement.UnitConversion(killogram, gram);
            Assert.IsFalse(compare);
        }

        /// <summary>
        /// Test case 8.1 :Given 100 Celsius and 212 Fahrenheit should return True
        /// </summary>
            [Test]
        public void Give_100CelsiusAnd212Fahrenheit_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement celsius = new QuantitiyMeasurement(Unit.CELSIUS, 100.0);
            QuantitiyMeasurement fahrenheit = new QuantitiyMeasurement(Unit.FAHRENHEIT, 212.0);
            bool compare = this.measurement.ConvertTemperature(celsius, fahrenheit);
            Assert.IsTrue(compare);
        }

        /// <summary>
        /// Test case 8.2 :Given 100 Fahrenheit and 100 Celsius should return False
        /// </summary>
        [Test]
        public void Given_100Fahrenheitand100Celsius_WhenCompared_ShouldReturnFalse()
        {
            QuantitiyMeasurement fahrenheit = new QuantitiyMeasurement(Unit.FAHRENHEIT, 100.0);
            QuantitiyMeasurement celsius = new QuantitiyMeasurement(Unit.CELSIUS, 100.0);
            bool compareCheck = this.measurement.ConvertTemperature(fahrenheit, celsius);
            Assert.IsFalse(compareCheck);
        }

        /// <summary>
        /// Test case 8.3 :Given 212 Fahrenheit and 100 Celsius should return True
        /// </summary>
        [Test]
        public void Given_212Fahrenheitand100Celsius_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement fahrenheit = new QuantitiyMeasurement(Unit.FAHRENHEIT, 212.0);
            QuantitiyMeasurement celsius = new QuantitiyMeasurement(Unit.CELSIUS, 100.0);
            bool compareCheck = this.measurement.ConvertTemperature(fahrenheit, celsius);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Test case Negative :Given Negative Fahrenheit and 100 Celsius should return True
        /// </summary>
        [Test]
        public void Given_Negative212Fahrenheitand100Celsius_WhenCompared_ShouldReturnTrue()
        {
            QuantitiyMeasurement fahrenheit = new QuantitiyMeasurement(Unit.FAHRENHEIT, -212.0);
            QuantitiyMeasurement celsius = new QuantitiyMeasurement(Unit.CELSIUS, 100.0);
            bool compareCheck = this.measurement.ConvertTemperature(fahrenheit, celsius);
            Assert.IsFalse(compareCheck);
        }
    }
}
