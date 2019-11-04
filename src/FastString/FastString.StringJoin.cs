#if NETSTANDARD2_0
using System.Runtime.CompilerServices;

namespace FastStringUtility
{
    partial class FastString
    {

        /// <summary>
        /// 指定した2個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1)
        {
            var length = str0.Length + str1.Length + 1;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);
            }

            return str;
        }


        /// <summary>
        /// 指定した3個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2)
        {
            var length = str0.Length + str1.Length + str2.Length + 2;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);
            }

            return str;
        }


        /// <summary>
        /// 指定した4個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + 3;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);
            }

            return str;
        }


        /// <summary>
        /// 指定した5個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + 4;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);
            }

            return str;
        }


        /// <summary>
        /// 指定した6個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + 5;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);
            }

            return str;
        }


        /// <summary>
        /// 指定した7個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + 6;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);
            }

            return str;
        }


        /// <summary>
        /// 指定した8個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + 7;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);
            }

            return str;
        }


        /// <summary>
        /// 指定した9個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + 8;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);
            }

            return str;
        }


        /// <summary>
        /// 指定した10個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <param name="str9">連結する10番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + 9;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str9);
            }

            return str;
        }


        /// <summary>
        /// 指定した11個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <param name="str9">連結する10番目の文字列</param>
        /// <param name="str10">連結する11番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + 10;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str10);
            }

            return str;
        }


        /// <summary>
        /// 指定した12個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <param name="str9">連結する10番目の文字列</param>
        /// <param name="str10">連結する11番目の文字列</param>
        /// <param name="str11">連結する12番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + 11;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str11);
            }

            return str;
        }


        /// <summary>
        /// 指定した13個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <param name="str9">連結する10番目の文字列</param>
        /// <param name="str10">連結する11番目の文字列</param>
        /// <param name="str11">連結する12番目の文字列</param>
        /// <param name="str12">連結する13番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + 12;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str12);
            }

            return str;
        }


        /// <summary>
        /// 指定した14個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <param name="str9">連結する10番目の文字列</param>
        /// <param name="str10">連結する11番目の文字列</param>
        /// <param name="str11">連結する12番目の文字列</param>
        /// <param name="str12">連結する13番目の文字列</param>
        /// <param name="str13">連結する14番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + 13;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str12);

                destination += str12.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str13);
            }

            return str;
        }


        /// <summary>
        /// 指定した15個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <param name="str9">連結する10番目の文字列</param>
        /// <param name="str10">連結する11番目の文字列</param>
        /// <param name="str11">連結する12番目の文字列</param>
        /// <param name="str12">連結する13番目の文字列</param>
        /// <param name="str13">連結する14番目の文字列</param>
        /// <param name="str14">連結する15番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + str14.Length + 14;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str12);

                destination += str12.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str13);

                destination += str13.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str14);
            }

            return str;
        }


        /// <summary>
        /// 指定した16個の文字列を連結します。各要素の間には、指定した区切り記号が挿入されます。
        /// </summary>
        /// <param name="separator">区切り記号</param>
        /// <param name="str0">連結する最初の文字列</param>
        /// <param name="str1">連結する2番目の文字列</param>
        /// <param name="str2">連結する3番目の文字列</param>
        /// <param name="str3">連結する4番目の文字列</param>
        /// <param name="str4">連結する5番目の文字列</param>
        /// <param name="str5">連結する6番目の文字列</param>
        /// <param name="str6">連結する7番目の文字列</param>
        /// <param name="str7">連結する8番目の文字列</param>
        /// <param name="str8">連結する9番目の文字列</param>
        /// <param name="str9">連結する10番目の文字列</param>
        /// <param name="str10">連結する11番目の文字列</param>
        /// <param name="str11">連結する12番目の文字列</param>
        /// <param name="str12">連結する13番目の文字列</param>
        /// <param name="str13">連結する14番目の文字列</param>
        /// <param name="str14">連結する15番目の文字列</param>
        /// <param name="str15">連結する16番目の文字列</param>
        /// <returns>文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Join(char separator, string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14, string str15)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + str14.Length + str15.Length + 15;

            var str = new string(default, length);

            fixed (char* strPointer = str)
            {
                var destination = strPointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str12);

                destination += str12.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str13);

                destination += str13.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str14);

                destination += str14.Length;
                *destination++ = separator;
                BinaryHelper.Copy(destination, str15);
            }

            return str;
        }
    }
}
#endif