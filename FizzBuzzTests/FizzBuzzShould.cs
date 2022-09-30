using FizzBuzzLinq;
using FluentAssertions;

namespace FizzBuzzTests;

public class FizzBuzzShould
{
    [Fact]
    public void Return_Array_With_One_Element_And_1_As_String_Inside()
    {
        var result = FizzBuzz.Translate(1);
        result.Should()
            .ContainSingle(predicate: s => s == "1");
    }

    [Fact]
    public void Return_Array_With_Two_Elements_And_1_2_As_String_Inside()
    {
        var result = FizzBuzz.Translate(2);
        result.Should()
            .HaveCount(2)
            .And
            .ContainInOrder(new[] { "1", "2" });
    }
    
    [Fact]
    public void Return_Array_With_Three_Elements_And_1_2_Fizz_As_String_Inside()
    {
        var result = FizzBuzz.Translate(3);
        result.Should()
            .HaveCount(3)
            .And
            .ContainInOrder(new[] { "1", "2", "Fizz" });
    }
    
    [Fact]
    public void Return_Array_With_Five_Elements_And_1_2_Fizz_4_Buzz_As_String_Inside()
    {
        var result = FizzBuzz.Translate(5);
        result.Should()
            .HaveCount(5)
            .And
            .ContainInOrder(new[] { "1", "2", "Fizz","4","Buzz" });
    }
    
    [Fact]
    public void Return_Array_With_Fifteen_Elements()
    {
        var result = FizzBuzz.Translate(15);
        result.Should()
            .HaveCount(15)
            .And
            .ContainInOrder(
                "1", "2", "Fizz", 
                "4", "Buzz", "Fizz", 
                "7", "8", "Fizz", 
                "Buzz", "11", "Fizz",
                "13", "14", "FizzBuzz");
    }
    
}