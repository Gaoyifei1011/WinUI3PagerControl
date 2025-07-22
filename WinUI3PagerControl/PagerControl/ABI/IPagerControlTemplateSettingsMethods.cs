using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT;
using WinRT.GenericTypeInstantiations;

namespace ABI.Microsoft.UI.Xaml.Controls;

internal static class IPagerControlTemplateSettingsMethods
{
    public static ref readonly Guid IID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference((ReadOnlySpan<byte>)
            [
                19, 102, 161, 244, 69, 3, 65, 88, 181, 26,
                34, 115, 16, 121, 119, 39
            ]));
        }
    }

    internal static unsafe IList<object> get_NumberPanelItems(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 7 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            Windows_Foundation_Collections_IVector_1_object.EnsureInitialized();
            return MarshalInterface<IList<object>>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<IList<object>>.DisposeAbi(intPtr);
        }
    }

    internal static unsafe IList<object> get_Pages(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            Windows_Foundation_Collections_IVector_1_object.EnsureInitialized();
            return MarshalInterface<IList<object>>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<IList<object>>.DisposeAbi(intPtr);
        }
    }
}