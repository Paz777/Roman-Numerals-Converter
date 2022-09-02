using System;
using NUnit.Framework;
using FluentAssertions;
using RomanNumeralsConverter.Models;
using System.Collections.Generic;


namespace RomanNumeralsConverter.Tests
{
    public class RomanNumeralsTests
    {
        private RomanNumerals RomanNumeral;

        [SetUp]
        public void Setup()
        {
            RomanNumeral = new RomanNumerals();
        }

        [Test]
        public void Given_A_Roman_Numeral_Should_Return_The_Correct_Number()
        {
            RomanNumeral.ConvertRomanNumeral("I").Should().Be(1);
            RomanNumeral.ConvertRomanNumeral("II").Should().Be(2);
            RomanNumeral.ConvertRomanNumeral("III").Should().Be(3);
            RomanNumeral.ConvertRomanNumeral("IV").Should().Be(4);
            RomanNumeral.ConvertRomanNumeral("V").Should().Be(5);
            RomanNumeral.ConvertRomanNumeral("VI").Should().Be(6);
            RomanNumeral.ConvertRomanNumeral("VII").Should().Be(7);
            RomanNumeral.ConvertRomanNumeral("VIII").Should().Be(8);
            RomanNumeral.ConvertRomanNumeral("IX").Should().Be(9);
            RomanNumeral.ConvertRomanNumeral("X").Should().Be(10);
        }

        [Test]
        public void Method_ConvertRomanNumeral_Should_Handle_Invalid_String_Inputs()
        {
            var invalidInput = "A";
            var ex = Assert.Throws<KeyNotFoundException>(() => RomanNumeral.ConvertRomanNumeral(invalidInput));
            Assert.That(ex.Message, Is.EqualTo("The given key '" +invalidInput + "' was not present in the dictionary."));

            invalidInput = "XYZ";
            ex = Assert.Throws<KeyNotFoundException>(() => RomanNumeral.ConvertRomanNumeral(invalidInput));
            Assert.That(ex.Message, Is.EqualTo("The given key '" + invalidInput + "' was not present in the dictionary."));

            invalidInput = "Paz";
            ex = Assert.Throws<KeyNotFoundException>(() => RomanNumeral.ConvertRomanNumeral(invalidInput));
            Assert.That(ex.Message, Is.EqualTo("The given key '" + invalidInput + "' was not present in the dictionary."));
        }
    }
}