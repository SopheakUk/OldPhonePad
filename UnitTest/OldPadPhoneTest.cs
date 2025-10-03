using OldPhonePad;

namespace UnitTest;

public class OldPadPhoneTest
{
    [Test]
    public void Test222_2_22MustBeCAB()
    {
        var input = "222 2 22";
        var expectedResult = "CAB";
        var result = Nokia.OldPhonePad(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test33MustBeE()
    {
        var input = "33#";
        var expectedResult = "E";
        var result = Nokia.OldPhonePad(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test227MustBeB()
    {
        var input = "227*#";
        var expectedResult = "B";
        var result = Nokia.OldPhonePad(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test4433555_555666MustBeHELLO()
    {
        var input = "4433555 555666#";
        var expectedResult = "HELLO";
        var result = Nokia.OldPhonePad(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test8_88777444666_664MustBeTURIMG()
    {
        var input = "8 88777444666*664#";
        var expectedResult = "TURING";
        var result = Nokia.OldPhonePad(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
