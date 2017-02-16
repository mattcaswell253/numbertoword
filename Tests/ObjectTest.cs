using Xunit;
using NumbersApp.Objects;
using System;
using System.Collections.Generic;

namespace NumbersApp
{
    public class NumbersTest
    {
        [Fact]
        public void NumbertoWord_ChangeNumberToWord_True()
        {
            //arrange
            Numbers NumbersTest = new Numbers(5);
            //act
            string word = NumbersTest.NumberToWord();
            //assert
            Assert.Equal("five", word);
        }
        [Fact]
        public void NumbertoWord_BiggerNumberToWord_True()
        {
            //arrange
            Numbers NumbersTest = new Numbers(18);
            //act
            string word = NumbersTest.NumberToWord();
            //assert
            Assert.Equal("eighteen", word);
        }
        [Fact]
        public void NumbertoWord_21To99NumberToWord_True()
        {
            //arrange
            Numbers NumbersTest = new Numbers(55);
            //act
            string word = NumbersTest.NumberToWord();
            //assert
            Assert.Equal("fiftyfive", word);
        }
    }
}
