using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FastStringUtility.Helpers;

namespace FastStringUtility.Extensions
{
    /// <summary>
    /// <see cref="string"/>関連の拡張メソッド
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 指定された文字列の指定された位置に文字列を挿入した、新しい文字列を返します。
        /// </summary>
        /// <param name="source">元の文字列</param>
        /// <param name="startIndex">位置</param>
        /// <param name="value">挿入する文字列</param>
        /// <returns>sourceのstartIndexの位置にvalueを挿入した新しい文字列</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Insert(this in ReadOnlySpan<char> source, int startIndex, in ReadOnlySpan<char> value)
        {
            if (startIndex < 0 || startIndex > source.Length)
                ThrowHelper.ThrowArgumentOutOfRangeException(nameof(startIndex));

            var oldLength = source.Length;
            var insertLength = value.Length;

            if (oldLength == 0)
                return value.ToString();

            if (insertLength == 0)
                return source.ToString();

            var length = checked(oldLength + insertLength);
            var result = new string(default, length);

            ref var resultStart = ref MemoryMarshal.GetReference(result.AsSpan());
            ref var sourceStart = ref MemoryMarshal.GetReference(source);
            ref var valueStart = ref MemoryMarshal.GetReference(value);

            BinaryHelper.Copy(ref resultStart, ref sourceStart, startIndex);

            resultStart = ref Unsafe.Add(ref resultStart, startIndex);
            BinaryHelper.Copy(ref resultStart, ref valueStart, insertLength);

            resultStart = ref Unsafe.Add(ref resultStart, insertLength);
            BinaryHelper.Copy(ref resultStart, ref Unsafe.Add(ref sourceStart, startIndex), oldLength - startIndex);

            return result;
        }
    }
}