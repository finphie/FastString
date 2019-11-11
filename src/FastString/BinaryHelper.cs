using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FastStringUtility
{
    /// <summary>
    /// バイナリ関連のヘルパークラス
    /// </summary>
    static class BinaryHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Copy<T>(ref T destination, ref T source, int count)
            where T : struct
        {
            ref var destinationStart = ref Unsafe.As<T, byte>(ref destination);
            ref var sourceStart = ref Unsafe.As<T, byte>(ref source);

            Unsafe.CopyBlockUnaligned(ref destinationStart, ref sourceStart, (uint)(count * Unsafe.SizeOf<T>()));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Copy<T>(in Span<T> destination, in ReadOnlySpan<T> source)
            where T : struct
            => Copy(destination, source, source.Length);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Copy<T>(in Span<T> destination, in ReadOnlySpan<T> source, int count)
            where T : struct
        {
            ref var destinationStart = ref MemoryMarshal.GetReference(destination);
            ref var sourceStart = ref MemoryMarshal.GetReference(source);

            Copy(ref destinationStart, ref sourceStart, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Copy<T>(in Span<T> destination, in ReadOnlySpan<T> source0, in ReadOnlySpan<T> source1)
            where T : struct
        {
            ref var destinationStart = ref MemoryMarshal.GetReference(destination);
            ref var sourceStart = ref MemoryMarshal.GetReference(source0);

            Copy(ref destinationStart, ref sourceStart, source0.Length);
            destinationStart = ref Unsafe.Add(ref destinationStart, source0.Length);
            Copy(ref destinationStart, ref MemoryMarshal.GetReference(source1), source1.Length);
        }
    }
}