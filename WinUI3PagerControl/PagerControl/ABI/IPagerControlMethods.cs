using ABI.System.Windows.Input;
using ABI.WinRT.Interop;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Input;
using Windows.Foundation;
using WinRT;

namespace ABI.Microsoft.UI.Xaml.Controls;

internal static class IPagerControlMethods
{
    private static volatile ConditionalWeakTable<object, EventSource<TypedEventHandler<global::Microsoft.UI.Xaml.Controls.PagerControl, global::Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>>> _SelectedIndexChanged_;

    private static ConditionalWeakTable<object, EventSource<TypedEventHandler<global::Microsoft.UI.Xaml.Controls.PagerControl, global::Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>>> _SelectedIndexChanged => _SelectedIndexChanged_ ?? MakeSelectedIndexChangedTable();

    public static ref readonly Guid IID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference((ReadOnlySpan<byte>)
            [
                195, 33, 41, 63, 159, 224, 241, 90, 144, 85,
                29, 61, 52, 132, 70, 127
            ]));
        }
    }

    internal static unsafe bool get_ButtonPanelAlwaysShowFirstLastPageIndex(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        byte b = 0;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, byte*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 36 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, byte*, int>))))(thisPtr, &b));
        return b != 0;
    }

    internal static unsafe void set_ButtonPanelAlwaysShowFirstLastPageIndex(IObjectReference _obj, bool value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, byte, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 37 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, byte, int>))))(thisPtr, value ? ((byte)1) : ((byte)0)));
    }

    internal static unsafe PagerControlDisplayMode get_DisplayMode(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        PagerControlDisplayMode result = PagerControlDisplayMode.Auto;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlDisplayMode*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlDisplayMode*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe void set_DisplayMode(IObjectReference _obj, PagerControlDisplayMode value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlDisplayMode, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 7 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlDisplayMode, int>))))(thisPtr, value));
    }

    internal static unsafe ICommand get_FirstButtonCommand(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 18 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return MarshalInterface<ICommand>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<ICommand>.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_FirstButtonCommand(IObjectReference _obj, ICommand value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInterface<ICommand>.CreateMarshaler2(value, ICommandMethods.IID);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 19 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.Style get_FirstButtonStyle(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 28 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return Style.FromAbi(intPtr);
        }
        finally
        {
            Style.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_FirstButtonStyle(IObjectReference _obj, global::Microsoft.UI.Xaml.Style value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = Style.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 29 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe PagerControlButtonVisibility get_FirstButtonVisibility(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        PagerControlButtonVisibility result = PagerControlButtonVisibility.Visible;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 10 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe void set_FirstButtonVisibility(IObjectReference _obj, PagerControlButtonVisibility value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 11 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>))))(thisPtr, value));
    }

    internal static unsafe ICommand get_LastButtonCommand(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 24 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return MarshalInterface<ICommand>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<ICommand>.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_LastButtonCommand(IObjectReference _obj, ICommand value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInterface<ICommand>.CreateMarshaler2(value, ICommandMethods.IID);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 25 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.Style get_LastButtonStyle(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 34 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return Style.FromAbi(intPtr);
        }
        finally
        {
            Style.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_LastButtonStyle(IObjectReference _obj, global::Microsoft.UI.Xaml.Style value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = Style.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 35 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe PagerControlButtonVisibility get_LastButtonVisibility(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        PagerControlButtonVisibility result = PagerControlButtonVisibility.Visible;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 16 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe void set_LastButtonVisibility(IObjectReference _obj, PagerControlButtonVisibility value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 17 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>))))(thisPtr, value));
    }

    internal static unsafe ICommand get_NextButtonCommand(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 22 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return MarshalInterface<ICommand>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<ICommand>.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_NextButtonCommand(IObjectReference _obj, ICommand value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInterface<ICommand>.CreateMarshaler2(value, ICommandMethods.IID);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 23 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.Style get_NextButtonStyle(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 32 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return Style.FromAbi(intPtr);
        }
        finally
        {
            Style.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_NextButtonStyle(IObjectReference _obj, global::Microsoft.UI.Xaml.Style value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = Style.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 33 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe PagerControlButtonVisibility get_NextButtonVisibility(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        PagerControlButtonVisibility result = PagerControlButtonVisibility.Visible;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 14 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe void set_NextButtonVisibility(IObjectReference _obj, PagerControlButtonVisibility value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 15 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>))))(thisPtr, value));
    }

    internal static unsafe int get_NumberOfPages(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        int result = 0;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, int*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 8 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, int*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe void set_NumberOfPages(IObjectReference _obj, int value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, int, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 9 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, int, int>))))(thisPtr, value));
    }

    internal static unsafe ICommand get_PagerInputCommand(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 26 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return MarshalInterface<ICommand>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<ICommand>.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_PagerInputCommand(IObjectReference _obj, ICommand value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInterface<ICommand>.CreateMarshaler2(value, ICommandMethods.IID);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 27 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe string get_PrefixText(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 40 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return MarshalString.FromAbi(intPtr);
        }
        finally
        {
            MarshalString.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_PrefixText(IObjectReference _obj, string value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        MarshalString.Pinnable p = new(value);
        fixed (char* ptr = p)
        {
            _ = ptr;
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 41 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalString.GetAbi(ref p)));
        }
    }

    internal static unsafe ICommand get_PreviousButtonCommand(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 20 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return MarshalInterface<ICommand>.FromAbi(intPtr);
        }
        finally
        {
            MarshalInterface<ICommand>.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_PreviousButtonCommand(IObjectReference _obj, ICommand value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = MarshalInterface<ICommand>.CreateMarshaler2(value, ICommandMethods.IID);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 21 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.Style get_PreviousButtonStyle(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 30 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return Style.FromAbi(intPtr);
        }
        finally
        {
            Style.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_PreviousButtonStyle(IObjectReference _obj, global::Microsoft.UI.Xaml.Style value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ObjectReferenceValue value2 = default;
        try
        {
            value2 = Style.CreateMarshaler2(value);
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 31 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value2)));
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(value2);
        }
    }

    internal static unsafe PagerControlButtonVisibility get_PreviousButtonVisibility(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        PagerControlButtonVisibility result = PagerControlButtonVisibility.Visible;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 12 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe void set_PreviousButtonVisibility(IObjectReference _obj, PagerControlButtonVisibility value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 13 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, PagerControlButtonVisibility, int>))))(thisPtr, value));
    }

    internal static unsafe int get_SelectedPageIndex(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        int result = 0;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, int*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 38 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, int*, int>))))(thisPtr, &result));
        return result;
    }

    internal static unsafe void set_SelectedPageIndex(IObjectReference _obj, int value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, int, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 39 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, int, int>))))(thisPtr, value));
    }

    internal static unsafe string get_SuffixText(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 42 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return MarshalString.FromAbi(intPtr);
        }
        finally
        {
            MarshalString.DisposeAbi(intPtr);
        }
    }

    internal static unsafe void set_SuffixText(IObjectReference _obj, string value)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        MarshalString.Pinnable p = new(value);
        fixed (char* ptr = p)
        {
            _ = ptr;
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 43 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, int>))))(thisPtr, MarshalString.GetAbi(ref p)));
        }
    }

    internal static unsafe global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings get_TemplateSettings(IObjectReference _obj)
    {
        IntPtr thisPtr = _obj.ThisPtr;
        IntPtr intPtr = default;
        try
        {
            ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>)(*(IntPtr*)(*(IntPtr*)(void*)thisPtr + 46 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr*, int>))))(thisPtr, &intPtr));
            return PagerControlTemplateSettings.FromAbi(intPtr);
        }
        finally
        {
            PagerControlTemplateSettings.DisposeAbi(intPtr);
        }
    }

    private static ConditionalWeakTable<object, EventSource<TypedEventHandler<global::Microsoft.UI.Xaml.Controls.PagerControl, global::Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>>> MakeSelectedIndexChangedTable()
    {
        Interlocked.CompareExchange(ref _SelectedIndexChanged_, [], null);
        return _SelectedIndexChanged_;
    }

    internal static unsafe EventSource<TypedEventHandler<global::Microsoft.UI.Xaml.Controls.PagerControl, global::Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>> Get_SelectedIndexChanged2(IObjectReference _obj, object _thisObj)
    {
        return _SelectedIndexChanged.GetValue(_thisObj, delegate
        {
            IntPtr thisPtr = _obj.ThisPtr;
            return new _EventSource_global__Windows_Foundation_TypedEventHandler_global__Microsoft_UI_Xaml_Controls_PagerControl__global__Microsoft_UI_Xaml_Controls_PagerControlSelectedIndexChangedEventArgs_(_obj, (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, EventRegistrationToken*, int>)(*(IntPtr*)((nint)(*(IntPtr*)(void*)thisPtr) + (nint)44 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, EventRegistrationToken*, int>))), (delegate* unmanaged[Stdcall]<IntPtr, EventRegistrationToken, int>)(*(IntPtr*)((nint)(*(IntPtr*)(void*)thisPtr) + (nint)45 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, EventRegistrationToken, int>))), 0);
        });
    }
}