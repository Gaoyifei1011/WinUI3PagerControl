using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT;

namespace ABI.Microsoft.UI.Xaml.Controls;

internal static class IPagerControlSelectedIndexChangedEventArgsMethods
{
    public static ref readonly Guid IID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference((ReadOnlySpan<byte>)
            [
                43, 86, 42, 161, 58, 192, 128, 95, 167, 229,
                82, 51, 17, 97, 5, 4
            ]));
        }
    }

    internal static unsafe int get_NewPageIndex(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        int result = 0;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, int*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, int*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe int get_PreviousPageIndex(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        int result = 0;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, int*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 7 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, int*, int>))))(thisPtr, &result));
        return result;
    }
}