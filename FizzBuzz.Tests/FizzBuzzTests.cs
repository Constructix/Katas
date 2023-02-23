using FizzBuzzLibrary;
using FluentAssertions;

namespace FizzBuzzTests;

public class FizzBuzzTest
{
   [Theory]
   [InlineData(1,"1")]
   [InlineData(2,"2")]
   [InlineData(4,"4")]
   [InlineData(3,"Fizz")]
   [InlineData(5,"Buzz")]
   [InlineData(6, "Fizz")]
   [InlineData(7, "7")]
   [InlineData(9,"Fizz")]
   [InlineData(10,"Buzz")]
   [InlineData(15, "FizzBuzz")]
   [InlineData(21, "Fizz")]
   [InlineData(30, "FizzBuzz")]
   public void InputShouldReturnExpectedResult(int input, string expectedResult)
   {
      var actualResult =  FizzBuzz.Submit(input);
      expectedResult.Should().Be(actualResult);
   }
}