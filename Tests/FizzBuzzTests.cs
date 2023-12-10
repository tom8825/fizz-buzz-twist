using fizz_buzz_twist;

namespace Tests;

public class FizzBuzzTests
{
    private FizzBuzz _fb;
    private int rangeMin = 1;
    private int rangeMax = 100;

    [SetUp]
    public void Setup()
    {
        _fb = new FizzBuzz(rangeMin, rangeMax);
    }

    [Test]
    public void fizzbuzz_getParseRules()
    {
        var rules = _fb.GetParseRules();
        Assert.That(rules, Is.Not.Null);
    }

    [Test]
    public void fizzbuzz_output_length_correct()
    {
        var expectedArrayLength = rangeMax - (rangeMin-1);
        Assert.That(_fb.output.Count(), Is.EqualTo(expectedArrayLength));
    }

    [Test]
    public void fizzbuzz_index2_equals_Fizz()
    {
        Assert.That(_fb.output[2], Is.EqualTo("Fizz"));
    }

    [Test]
    public void fizzbuzz_index4_equals_Buzz()
    {
        Assert.That(_fb.output[4], Is.EqualTo("Buzz"));
    }

    [Test]
    public void fizzbuzz_index14_equals_FizzBuzz()
    {
        Assert.That(_fb.output[14], Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void fizzbuzz_index7_equals_8()
    {
        Assert.That(_fb.output[7], Is.EqualTo("8"));
    }
}
