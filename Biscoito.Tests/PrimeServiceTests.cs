using Xunit;

namespace Biscoito.Tests
{
    public class PrimeServiceTests
    {
        private PrimeService _primeService;  

        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "Deve retornar falso se o valor for 1");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ReturnFalseGivenValueOf0(int number)
        {
            var result = _primeService.IsPrime(number);

            Assert.False(result, "Deve retornar falso se o valor for 0");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(373)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(17)]
        public void NumerosPrimos(int number)
        {
            var result = _primeService.IsPrime(number);
            Assert.True(result, $"Deve retornar true se o valor for {number}");
        }


    }
}
