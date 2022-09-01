using System;
using NUnit.Framework;
using FluentAssertions;
using RomanNumeralsConverter.Models;


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
        }
    }
}