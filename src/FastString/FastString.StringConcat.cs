#if NETSTANDARD2_0
using System.Runtime.CompilerServices;

namespace FastStringUtility
{
    partial class FastString
    {
        /// <summary>
        /// �w�肵��2�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1)
        {
            var length = str0.Length + str1.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��3�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2)
        {
            var length = str0.Length + str1.Length + str2.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��4�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��5�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��6�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��7�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��8�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��9�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��10�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <param name="str9">�A������10�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                BinaryHelper.Copy(destination, str9);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��11�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <param name="str9">�A������10�Ԗڂ̕�����</param>
        /// <param name="str10">�A������11�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                BinaryHelper.Copy(destination, str10);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��12�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <param name="str9">�A������10�Ԗڂ̕�����</param>
        /// <param name="str10">�A������11�Ԗڂ̕�����</param>
        /// <param name="str11">�A������12�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                BinaryHelper.Copy(destination, str11);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��13�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <param name="str9">�A������10�Ԗڂ̕�����</param>
        /// <param name="str10">�A������11�Ԗڂ̕�����</param>
        /// <param name="str11">�A������12�Ԗڂ̕�����</param>
        /// <param name="str12">�A������13�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                BinaryHelper.Copy(destination, str12);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��14�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <param name="str9">�A������10�Ԗڂ̕�����</param>
        /// <param name="str10">�A������11�Ԗڂ̕�����</param>
        /// <param name="str11">�A������12�Ԗڂ̕�����</param>
        /// <param name="str12">�A������13�Ԗڂ̕�����</param>
        /// <param name="str13">�A������14�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                BinaryHelper.Copy(destination, str12);

                destination += str12.Length;
                BinaryHelper.Copy(destination, str13);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��15�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <param name="str9">�A������10�Ԗڂ̕�����</param>
        /// <param name="str10">�A������11�Ԗڂ̕�����</param>
        /// <param name="str11">�A������12�Ԗڂ̕�����</param>
        /// <param name="str12">�A������13�Ԗڂ̕�����</param>
        /// <param name="str13">�A������14�Ԗڂ̕�����</param>
        /// <param name="str14">�A������15�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + str14.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                BinaryHelper.Copy(destination, str12);

                destination += str12.Length;
                BinaryHelper.Copy(destination, str13);

                destination += str13.Length;
                BinaryHelper.Copy(destination, str14);
            }

            return str;
        }

        /// <summary>
        /// �w�肵��16�̕������A�����܂��B
        /// </summary>
        /// <param name="str0">�A������ŏ��̕�����</param>
        /// <param name="str1">�A������2�Ԗڂ̕�����</param>
        /// <param name="str2">�A������3�Ԗڂ̕�����</param>
        /// <param name="str3">�A������4�Ԗڂ̕�����</param>
        /// <param name="str4">�A������5�Ԗڂ̕�����</param>
        /// <param name="str5">�A������6�Ԗڂ̕�����</param>
        /// <param name="str6">�A������7�Ԗڂ̕�����</param>
        /// <param name="str7">�A������8�Ԗڂ̕�����</param>
        /// <param name="str8">�A������9�Ԗڂ̕�����</param>
        /// <param name="str9">�A������10�Ԗڂ̕�����</param>
        /// <param name="str10">�A������11�Ԗڂ̕�����</param>
        /// <param name="str11">�A������12�Ԗڂ̕�����</param>
        /// <param name="str12">�A������13�Ԗڂ̕�����</param>
        /// <param name="str13">�A������14�Ԗڂ̕�����</param>
        /// <param name="str14">�A������15�Ԗڂ̕�����</param>
        /// <param name="str15">�A������16�Ԗڂ̕�����</param>
        /// <returns>������</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string Concat(string str0, string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14, string str15)
        {
            var length = str0.Length + str1.Length + str2.Length + str3.Length + str4.Length + str5.Length + str6.Length + str7.Length + str8.Length + str9.Length + str10.Length + str11.Length + str12.Length + str13.Length + str14.Length + str15.Length;

            var str = new string(default, length);

            fixed (char* pointer = str)
            {
                var destination = pointer;
                BinaryHelper.Copy(destination, str0);

                destination += str0.Length;
                BinaryHelper.Copy(destination, str1);

                destination += str1.Length;
                BinaryHelper.Copy(destination, str2);

                destination += str2.Length;
                BinaryHelper.Copy(destination, str3);

                destination += str3.Length;
                BinaryHelper.Copy(destination, str4);

                destination += str4.Length;
                BinaryHelper.Copy(destination, str5);

                destination += str5.Length;
                BinaryHelper.Copy(destination, str6);

                destination += str6.Length;
                BinaryHelper.Copy(destination, str7);

                destination += str7.Length;
                BinaryHelper.Copy(destination, str8);

                destination += str8.Length;
                BinaryHelper.Copy(destination, str9);

                destination += str9.Length;
                BinaryHelper.Copy(destination, str10);

                destination += str10.Length;
                BinaryHelper.Copy(destination, str11);

                destination += str11.Length;
                BinaryHelper.Copy(destination, str12);

                destination += str12.Length;
                BinaryHelper.Copy(destination, str13);

                destination += str13.Length;
                BinaryHelper.Copy(destination, str14);

                destination += str14.Length;
                BinaryHelper.Copy(destination, str15);
            }

            return str;
        }
    }
}
#endif