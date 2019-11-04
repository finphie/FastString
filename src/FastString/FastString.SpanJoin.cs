#if NETCOREAPP3_0 || NETSTANDARD2_1
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1)
        {
            var length = str0.Length + str1.Length + 1;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2)
        {
            var length = str0.Length + str1.Length + str2.Length + 2;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + 3;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + 4;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + 5;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + 6;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + 7;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + 8;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8, in ReadOnlySpan<char> str9)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + 9;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);
            Unsafe.Add(ref strStart, str8.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str8.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str9), str9.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8, in ReadOnlySpan<char> str9, in ReadOnlySpan<char> str10)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + 10;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);
            Unsafe.Add(ref strStart, str8.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str8.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str9), str9.Length);
            Unsafe.Add(ref strStart, str9.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str9.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str10), str10.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8, in ReadOnlySpan<char> str9, in ReadOnlySpan<char> str10, in ReadOnlySpan<char> str11)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + 11;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);
            Unsafe.Add(ref strStart, str8.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str8.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str9), str9.Length);
            Unsafe.Add(ref strStart, str9.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str9.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str10), str10.Length);
            Unsafe.Add(ref strStart, str10.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str10.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str11), str11.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8, in ReadOnlySpan<char> str9, in ReadOnlySpan<char> str10, in ReadOnlySpan<char> str11, in ReadOnlySpan<char> str12)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + 12;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);
            Unsafe.Add(ref strStart, str8.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str8.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str9), str9.Length);
            Unsafe.Add(ref strStart, str9.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str9.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str10), str10.Length);
            Unsafe.Add(ref strStart, str10.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str10.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str11), str11.Length);
            Unsafe.Add(ref strStart, str11.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str11.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str12), str12.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8, in ReadOnlySpan<char> str9, in ReadOnlySpan<char> str10, in ReadOnlySpan<char> str11, in ReadOnlySpan<char> str12, in ReadOnlySpan<char> str13)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + 13;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);
            Unsafe.Add(ref strStart, str8.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str8.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str9), str9.Length);
            Unsafe.Add(ref strStart, str9.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str9.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str10), str10.Length);
            Unsafe.Add(ref strStart, str10.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str10.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str11), str11.Length);
            Unsafe.Add(ref strStart, str11.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str11.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str12), str12.Length);
            Unsafe.Add(ref strStart, str12.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str12.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str13), str13.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8, in ReadOnlySpan<char> str9, in ReadOnlySpan<char> str10, in ReadOnlySpan<char> str11, in ReadOnlySpan<char> str12, in ReadOnlySpan<char> str13, in ReadOnlySpan<char> str14)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + str14.Length + 14;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);
            Unsafe.Add(ref strStart, str8.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str8.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str9), str9.Length);
            Unsafe.Add(ref strStart, str9.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str9.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str10), str10.Length);
            Unsafe.Add(ref strStart, str10.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str10.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str11), str11.Length);
            Unsafe.Add(ref strStart, str11.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str11.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str12), str12.Length);
            Unsafe.Add(ref strStart, str12.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str12.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str13), str13.Length);
            Unsafe.Add(ref strStart, str13.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str13.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str14), str14.Length);

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
        public static string Join(char separator, in ReadOnlySpan<char> str0, in ReadOnlySpan<char> str1, in ReadOnlySpan<char> str2, in ReadOnlySpan<char> str3, in ReadOnlySpan<char> str4, in ReadOnlySpan<char> str5, in ReadOnlySpan<char> str6, in ReadOnlySpan<char> str7, in ReadOnlySpan<char> str8, in ReadOnlySpan<char> str9, in ReadOnlySpan<char> str10, in ReadOnlySpan<char> str11, in ReadOnlySpan<char> str12, in ReadOnlySpan<char> str13, in ReadOnlySpan<char> str14, in ReadOnlySpan<char> str15)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + str14.Length + str15.Length + 15;

            var str = new string(default, length);
            ref var strStart = ref MemoryMarshal.GetReference(str.AsSpan());

            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str0), str0.Length);
            Unsafe.Add(ref strStart, str0.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str0.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str1), str1.Length);
            Unsafe.Add(ref strStart, str1.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str1.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str2), str2.Length);
            Unsafe.Add(ref strStart, str2.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str2.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str3), str3.Length);
            Unsafe.Add(ref strStart, str3.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str3.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str4), str4.Length);
            Unsafe.Add(ref strStart, str4.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str4.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str5), str5.Length);
            Unsafe.Add(ref strStart, str5.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str5.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str6), str6.Length);
            Unsafe.Add(ref strStart, str6.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str6.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str7), str7.Length);
            Unsafe.Add(ref strStart, str7.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str7.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str8), str8.Length);
            Unsafe.Add(ref strStart, str8.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str8.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str9), str9.Length);
            Unsafe.Add(ref strStart, str9.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str9.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str10), str10.Length);
            Unsafe.Add(ref strStart, str10.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str10.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str11), str11.Length);
            Unsafe.Add(ref strStart, str11.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str11.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str12), str12.Length);
            Unsafe.Add(ref strStart, str12.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str12.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str13), str13.Length);
            Unsafe.Add(ref strStart, str13.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str13.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str14), str14.Length);
            Unsafe.Add(ref strStart, str14.Length) = separator;

            strStart = ref Unsafe.Add(ref strStart, str14.Length + 1);
            BinaryHelper.Copy(ref strStart, ref MemoryMarshal.GetReference(str15), str15.Length);

            return str;
        }
    }
}
#endif