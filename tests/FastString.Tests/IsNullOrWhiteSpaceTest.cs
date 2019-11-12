using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace FastStringUtility.Tests
{
    public class IsNullOrWhiteSpaceTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("  ")]
        public void Null_空文字列_空白文字を入力_trueを返す(string value)
        {
            var actual = FastString.IsNullOrWhiteSpace(value);

            actual.Should().BeTrue();
        }

        [Theory, AutoData]
        public void 文字列を入力_falseを返す(string value)
        {
            var actual = FastString.IsNullOrWhiteSpace(value);

            actual.Should().BeFalse();
        }
    }
}