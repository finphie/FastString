using System;
using System.ComponentModel.DataAnnotations;
using AutoFixture.Xunit2;
using FastStringUtility.Extensions;
using FluentAssertions;
using Xunit;

namespace FastStringUtility.Tests
{
    public class InsertTest
    {
        [Theory, AutoData]
        [InlineData("", 0, "1")]
        [InlineData("a", 0, "")]
        [InlineData("a", 0, "1")]
        [InlineData("a", 1, "1")]
        public void 文字列_開始位置_文字列を入力_挿入した文字列を返す([MinLength(5)]string source, [Range(1, 3)]int startIndex, string value)
        {
            var actual = source.AsSpan().Insert(startIndex, value);
            var expected = source.Insert(startIndex, value);

            actual.Should().Contain(expected);
        }

        [Theory]
        [InlineData(null, 0, null)]
        [InlineData("", 0, null)]
        [InlineData("", 0, "")]
        public void 文字列_開始位置_文字列を入力_空文字列を返す(string source, int startIndex, string value)
        {
            var actual = source.AsSpan().Insert(startIndex, value);

            actual.Should().BeEmpty();
        }


        [Theory]
        [InlineData("", 1, "")]
        [InlineData("", -1, "")]
        public void 文字列の長さが範囲外_ArgumentOutOfRangeException(string source, int startIndex, string value)
        {
            FluentActions.Invoking(() => source.AsSpan().Insert(startIndex, value))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }
    }
}