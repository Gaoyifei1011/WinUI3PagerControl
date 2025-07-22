using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT;

namespace ABI.Microsoft.UI.Xaml.Controls;

internal static class IPagerControlFactoryMethods
{
    public static ref readonly Guid IID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference((ReadOnlySpan<byte>)
            [
                57, 26, 55, 11, 201, 245, 1, 86, 177, 233,
                57, 228, 244, 118, 5, 146
            ]));
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.Controls.PagerControl CreateInstance(IObjectReference _obj, object baseInterface, out object innerInterface)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value = default;
        IntPtr ptr = default;
        IntPtr intPtr = default;
        try
        {
            value = MarshalInspectable<object>.CreateMarshaler2(baseInterface);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>)(*(IntPtr*)((nint)(*(IntPtr*)(void*)thisPtr) + (nint)6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value), &ptr, &intPtr));
            innerInterface = MarshalInspectable<object>.FromAbi(ptr);
            return PagerControl.FromAbi(intPtr);
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value);
            MarshalInspectable<object>.DisposeAbi(ptr);
            PagerControl.DisposeAbi(intPtr);
        }
    }
}