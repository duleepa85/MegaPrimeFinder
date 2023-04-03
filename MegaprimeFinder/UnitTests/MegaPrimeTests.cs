using MegaprimeFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class MegaPrimeTests
    {
        /// <summary>
        /// Test with the lower limit - Unsigned integer min values (0 and 1) 
        /// </summary>
        /// <param name="max"></param>
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void MegaPrime_MaxLessThan2_ReturnEmptyList(uint max) 
        {
            List<uint> expected = new List<uint> { };
            List<uint> actual = MegaPrimeFunction.GetMegaPrimeList(max);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Test with a known integer
        /// </summary>
        [Fact]
        public void MegaPrime_MaxIsKnownInteger_ReturnKnownList()
        {
            uint max = 40;
            List<uint> expected = new List<uint> {2,3,5,7,23,37};
            List<uint> actual = MegaPrimeFunction.GetMegaPrimeList(max);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Testing when max = 2 (since 2 is added seperately to the list in the function - megaPrimeList.Add(2);
        /// </summary>
        [Fact]
        public void MegaPrime_MaxIs2_Return2()
        {
            uint max = 2;
            List<uint> expected = new List<uint> { 2 };
            List<uint> actual = MegaPrimeFunction.GetMegaPrimeList(max);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// To check whether max is inclusive in the return list
        /// </summary>
        [Fact]
        public void MegaPrime_MaxInclusive_ReturnWithMax()
        {
            uint max = 53;
            List<uint> expected = new List<uint> { 2, 3, 5, 7, 23, 37, 53 };
            List<uint> actual = MegaPrimeFunction.GetMegaPrimeList(max);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Testing the CheckDigits function - Making sure it returns false when 1 is there as a digit
        /// </summary>
        [Fact]
        public void MegaPrime_CheckDigits_OneIncluded_ReturnsFalse()
        {
            uint value = 31573;
            bool expected = false;
            bool actual = MegaPrimeFunction.CheckDigits(value);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Testing the CheckDigits function - Making sure it returns true when all the digits are prime
        /// </summary>
        [Fact]
        public void MegaPrime_CheckDigits_AllDigitsArePrime_ReturnsTrue()
        {
            uint value = 3572757;
            bool expected = true;
            bool actual = MegaPrimeFunction.CheckDigits(value);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Testing the CheckDigits function - Making sure it returns false when one digit is not prime
        /// </summary>
        [Fact]
        public void MegaPrime_CheckDigits_OneDigitIsNotPrime_ReturnsFalse()
        {
            uint value = 3574757;
            bool expected = false;
            bool actual = MegaPrimeFunction.CheckDigits(value);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Checking when  CheckDigits = true and IsPrime = false (Ex: If we take 35 as max, 35 should not be in the result prime list)
        /// </summary>
        [Fact]
        public void MegaPrime_CheckDigitIsTrueAndIsPrimeFalse_ReturnFalse()
        {
            uint max = 35;
            List<uint> expected = new List<uint> { 2, 3, 5, 7, 23};
            List<uint> actual = MegaPrimeFunction.GetMegaPrimeList(max);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Checking when CheckDigits = false and IsPrime = true (Ex: If we take 67 as max, 67 should not be in the result prime list)
        /// </summary>
        [Fact]
        public void MegaPrime_CheckDigitIsFalseAndIsPrimeTrue_ReturnFalse()
        {
            uint max = 67;
            List<uint> expected = new List<uint> { 2, 3, 5, 7, 23, 37, 53 };
            List<uint> actual = MegaPrimeFunction.GetMegaPrimeList(max);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Testing the upper limit - Unsigned integer maximum value (2^32 - 1 )
        /// </summary>
        //[Fact]
        //public void MegaPrime_32BitUnsignedIntegerMaximumValue_ReturnWithMax()
        //{
        //    uint max = (uint)(Math.Pow(2, 32) - 1);  //Upper limit of 32BitUnsignedInteger = 2^32 - 1 = 4294967295
        //    int expectedCount = Calculate()
        //    int actualCount = MegaPrimeFunction.GetMegaPrimeList(max).Count;
        //    Assert.Equal(expected, actualCount);
        //}

    }
}
