using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT;

namespace ABI.Microsoft.UI.Xaml.Controls;

internal static class IPagerControlTemplateSettingsFactoryMethods
{
    public static ref readonly Guid IID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference((ReadOnlySpan<byte>)
            [
                97, 86, 102, 37, 179, 138, 186, 80, 131, 247,
                42, 93, 10, 195, 116, 9
            ]));
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings CreateInstance(IObjectReference _obj, object baseInterface, out object innerInterface)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value = default;
        IntPtr ptr = default;
        IntPtr intPtr = default;
        try
        {
            value = MarshalInspectable<object>.CreateMarshaler2(baseInterface);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value), &ptr, &intPtr));
            innerInterface = MarshalInspectable<object>.FromAbi(ptr);
            return PagerControlTemplateSettings.FromAbi(intPtr);
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value);
            MarshalInspectable<object>.DisposeAbi(ptr);
            PagerControlTemplateSettings.DisposeAbi(intPtr);
        }
    }
}