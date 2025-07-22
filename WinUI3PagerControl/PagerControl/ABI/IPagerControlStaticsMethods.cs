using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT;

namespace ABI.Microsoft.UI.Xaml.Controls;

internal static class IPagerControlStaticsMethods
{
    public static ref readonly Guid IID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference((ReadOnlySpan<byte>)
            [
                141, 172, 12, 253, 108, 23, 242, 84, 150, 62,
                100, 19, 191, 228, 112, 154
            ]));
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_ButtonPanelAlwaysShowFirstLastPageIndexProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 21 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_DisplayModeProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_FirstButtonCommandProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 12 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_FirstButtonStyleProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 17 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_FirstButtonVisibilityProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 8 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_LastButtonCommandProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 15 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_LastButtonStyleProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 20 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_LastButtonVisibilityProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 11 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_NextButtonCommandProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 14 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_NextButtonStyleProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 19 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_NextButtonVisibilityProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 10 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_NumberOfPagesProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 7 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_PagerInputCommandProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 16 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_PrefixTextProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 23 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_PreviousButtonCommandProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 13 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_PreviousButtonStyleProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 18 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_PreviousButtonVisibilityProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 9 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_SelectedPageIndexProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 22 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.DependencyProperty get_SuffixTextProperty(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 24 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return DependencyProperty.FromAbi(intPtr);
        }
        finally
        {
            DependencyProperty.DisposeAbi(intPtr);
        }
    }
}