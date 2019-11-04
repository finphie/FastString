using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;

namespace FastStringUtility.Tests
{
    public class JoinTest
    {
        [Theory, AutoData]
        public void Parameter0_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1)
        {
            var str = FastString.Join(separator, str0, str1);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1));
        }

        [Theory, AutoData]
        public void Parameter1_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2)
        {
            var str = FastString.Join(separator, str0, str1, str2);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2));
        }

        [Theory, AutoData]
        public void Parameter2_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3));
        }

        [Theory, AutoData]
        public void Parameter3_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4));
        }

        [Theory, AutoData]
        public void Parameter4_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5));
        }

        [Theory, AutoData]
        public void Parameter5_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6));
        }

        [Theory, AutoData]
        public void Parameter6_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7));
        }

        [Theory, AutoData]
        public void Parameter7_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8));
        }

        [Theory, AutoData]
        public void Parameter8_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8, str9);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8, str9));
        }

        [Theory, AutoData]
        public void Parameter9_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10));
        }

        [Theory, AutoData]
        public void Parameter10_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11));
        }

        [Theory, AutoData]
        public void Parameter11_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12));
        }

        [Theory, AutoData]
        public void Parameter12_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13));
        }

        [Theory, AutoData]
        public void Parameter13_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14));
        }

        [Theory, AutoData]
        public void Parameter14_複数の文字列を入力_区切り記号で連結した文字列を返す(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14, string str15)
        {
            var str = FastString.Join(separator, str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15);

            str.Should().Contain(string.Join(separator.ToString(), str0, str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15));
        }
    }
}