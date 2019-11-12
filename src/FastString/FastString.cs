using System;
using System.Runtime.CompilerServices;

namespace FastStringUtility
{
    /// <summary>
    /// <see cref="string"/>関連のヘルパークラス
    /// </summary>
    public static partial class FastString
    {
        /// <summary>
        /// 指定された文字列がnullまたは空文字列であるかどうかを示します。
        /// </summary>
        /// <param name="value">対象の文字列</param>
        /// <returns>引数がnullまたは空文字列の場合は、true。それ以外の場合はfalse。</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty(in ReadOnlySpan<char> value)
            => value == null || value.Length == 0;
    }
}