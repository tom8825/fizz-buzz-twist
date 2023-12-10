using fizz_buzz_twist;

namespace Tests;

public class FizzBuzzTests
{
    private FizzBuzz _fb;
    private int rangeMin = 1;
    private int rangeMax = 10;

    [SetUp]
    public void Setup()
    {
        _fb = new FizzBuzz(rangeMin, rangeMax);
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
    public void fizzbuzz_index5_equals_FizzBuzz()
    {
        Assert.That(_fb.output[5], Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void fizzbuzz_index7_equals_8()
    {
        Assert.That(_fb.output[7], Is.EqualTo("8"));
    }
}
