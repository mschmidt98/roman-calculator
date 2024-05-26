using RomanCalculator.Core;
using RomanCalculator.Core.Contracts;

namespace RomanCalculator.Tests;

public class RomanToArabicTests
{
    // test cases borrowed from https://stackoverflow.com/a/22039673
    private readonly IRomanParsingService _parsingService = new RomanParsingService();
    
    [Fact]
    public void Roman_I_1()
    {
        Assert.Equal(1, _parsingService.ToArabic("I"));
    }

    [Fact]
    public void Roman_II_2()
    {
        Assert.Equal(2, _parsingService.ToArabic("II"));
    }

    [Fact]
    public void Roman_III_3()
    {
        Assert.Equal(3, _parsingService.ToArabic("III"));
    }

    [Fact]
    public void Roman_IV_4()
    {
        Assert.Equal(4, _parsingService.ToArabic("IV"));
    }

    [Fact]
    public void Roman_V_5()
    {
        Assert.Equal(5, _parsingService.ToArabic("V"));
    }

    [Fact]
    public void Roman_IX_9()
    {
        Assert.Equal(9, _parsingService.ToArabic("IX"));
    }

    [Fact]
    public void Roman_X_10()
    {
        Assert.Equal(10, _parsingService.ToArabic("X"));
    }

    [Fact]
    public void Roman_XLIX_49()
    {
        Assert.Equal(49, _parsingService.ToArabic("XLIX"));
    }

    [Fact]
    public void Roman_L_50()
    {
        Assert.Equal(50, _parsingService.ToArabic("L"));
    }

    [Fact]
    public void Roman_C_100()
    {
        Assert.Equal(100, _parsingService.ToArabic("C"));
    }

    [Fact]
    public void Roman_CD_400()
    {
        Assert.Equal(400, _parsingService.ToArabic("CD"));
    }

    [Fact]
    public void Roman_D_500()
    {
        Assert.Equal(500, _parsingService.ToArabic("D"));
    }

    [Fact]
    public void Roman_CM_900()
    {
        Assert.Equal(900, _parsingService.ToArabic("CM"));
    }

    [Fact]
    public void Roman_M_1000()
    {
        Assert.Equal(1000, _parsingService.ToArabic("M"));
    }

    [Fact]
    public void Roman_MMMMMMMMMMMCMLXXXIV_11984()
    {
        Assert.Equal(11984, _parsingService.ToArabic("MMMMMMMMMMMCMLXXXIV"));
    }
}