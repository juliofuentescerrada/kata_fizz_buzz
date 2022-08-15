namespace FizzBuzzKata.Specs
{
    public class fizzbuzz
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        public void should_print_a_number(int value)
        {
            var result = FizzBuzz.CalculateValue(value);
            Assert.Equal(value.ToString(), result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void should_print_fizz_when_a_number_is_divisible_by_3(int value)
        {
            var result = FizzBuzz.CalculateValue(value);
            Assert.Equal("fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void should_print_buzz_when_a_number_is_divisible_by_5(int value)
        {
            var result = FizzBuzz.CalculateValue(value);
            Assert.Equal("buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void should_print_fizzbuzz_when_a_number_is_divisible_by_3_and_5(int value)
        {
            var result = FizzBuzz.CalculateValue(value);
            Assert.Equal("fizzbuzz", result);
        }
    }
}