using RomanCalculator.Core;
using RomanCalculator.Core.Contracts;

namespace RomanCalculator.Tests;


public class ArabicToRomanTests
{
    // test cases borrowed from https://stackoverflow.com/a/22039673
    private readonly IRomanParsingService _parsingService = new RomanParsingService();
    
    [Fact]
    public void Roman_1_I()
    {
        Assert.Equal("I", _parsingService.ToRoman(1));
    }

    [Fact]
    public void Roman_2_II()
    {
        Assert.Equal("II", _parsingService.ToRoman(2));
    }

    [Fact]
    public void Roman_3_III()
    {
        Assert.Equal("III", _parsingService.ToRoman(3));
    }

    [Fact]
    public void Roman_4_IV()
    {
        Assert.Equal("IV", _parsingService.ToRoman(4));
    }

    [Fact]
    public void Roman_5_V()
    {
        Assert.Equal("V", _parsingService.ToRoman(5));
    }

    [Fact]
    public void Roman_9_IX()
    {
        Assert.Equal("IX", _parsingService.ToRoman(9));
    }

    [Fact]
    public void Roman_10_X()
    {
        Assert.Equal("X", _parsingService.ToRoman(10));
    }

    [Fact]
    public void Roman_49_XLIX()
    {
        Assert.Equal("XLIX", _parsingService.ToRoman(49));
    }

    [Fact]
    public void Roman_50_L()
    {
        Assert.Equal("L", _parsingService.ToRoman(50));
    }

    [Fact]
    public void Roman_100_C()
    {
        Assert.Equal("C", _parsingService.ToRoman(100));
    }

    [Fact]
    public void Roman_400_CD()
    {
        Assert.Equal("CD", _parsingService.ToRoman(400));
    }

    [Fact]
    public void Roman_500_D()
    {
        Assert.Equal("D", _parsingService.ToRoman(500));
    }

    [Fact]
    public void Roman_900_CM()
    {
        Assert.Equal("CM", _parsingService.ToRoman(900));
    }

    [Fact]
    public void Roman_1000_M()
    {
        Assert.Equal("M", _parsingService.ToRoman(1000));
    }

    [Fact]
    public void Roman_11984_MMMMMMMMMMMCMLXXXIV()
    {
        Assert.Equal("MMMMMMMMMMMCMLXXXIV", _parsingService.ToRoman(11984));
    }
}