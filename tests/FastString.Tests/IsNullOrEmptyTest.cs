using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace FastStringUtility.Tests
{
    public class IsNullOrEmptyTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Null_空文字列を入力_trueを返す(string value)
        {
            var actual = FastString.IsNullOrEmpty(value);

            actual.Should().BeTrue();
        }

        [Theory, AutoData]
        public void 文字列を入力_falseを返す(string value)
        {
            var actual = FastString.IsNullOrEmpty(value);

            actual.Should().BeFalse();
        }
    }
}