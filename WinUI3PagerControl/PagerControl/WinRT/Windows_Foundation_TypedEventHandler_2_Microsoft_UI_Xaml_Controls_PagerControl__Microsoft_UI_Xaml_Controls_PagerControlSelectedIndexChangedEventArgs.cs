using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WinRT.GenericTypeInstantiations;

internal static class Windows_Foundation_TypedEventHandler_2_Microsoft_UI_Xaml_Controls_PagerControl__Microsoft_UI_Xaml_Controls_PagerControlSelectedIndexChangedEventArgs
{
    private static bool Initialized { get; } = Init();

    public static bool EnsureInitialized() => Initialized;

    private static unsafe void Invoke(IObjectReference _obj, Microsoft.UI.Xaml.Controls.PagerControl sender, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs args)
    {
        var ThisPtr = _obj.ThisPtr;

        ObjectReferenceValue __sender = default;
        ObjectReferenceValue __args = default;
        try
        {
            __sender = ABI.Microsoft.UI.Xaml.Controls.PagerControl.CreateMarshaler2(sender);
            __args = ABI.Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs.CreateMarshaler2(args);
            ExceptionHelpers.ThrowExceptionForHR((*(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr, int>**)ThisPtr)[3](ThisPtr, MarshalInspectable<object>.GetAbi(__sender), MarshalInspectable<object>.GetAbi(__args)));
            GC.KeepAlive(_obj);
        }
        finally
        {
            MarshalInspectable<object>.DisposeMarshaler(__sender);
            MarshalInspectable<object>.DisposeMarshaler(__args);
        }
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
    private static unsafe int Do_Abi_Invoke(IntPtr thisPtr, IntPtr sender, IntPtr args)
    {
        try
        {
            ABI.Windows.Foundation.TypedEventHandlerMethods<Microsoft.UI.Xaml.Controls.PagerControl, IntPtr, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs, IntPtr>.Abi_Invoke(thisPtr, ABI.Microsoft.UI.Xaml.Controls.PagerControl.FromAbi(sender), ABI.Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs.FromAbi(args));
        }
        catch (Exception __exception__)
        {
            ExceptionHelpers.SetErrorInfo(__exception__);
            return ExceptionHelpers.GetHRForException(__exception__);
        }
        return 0;
    }

    private static unsafe bool Init()
    {
        ABI.Windows.Foundation.TypedEventHandlerMethods<Microsoft.UI.Xaml.Controls.PagerControl, IntPtr, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs, IntPtr>.InitRcwHelper(&Invoke);
        ABI.Windows.Foundation.TypedEventHandlerMethods<Microsoft.UI.Xaml.Controls.PagerControl, IntPtr, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs, IntPtr>.InitCcw(&Do_Abi_Invoke);

        return true;
    }
}