using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using WinRT;
using WinRT.Interop;

namespace ABI.Microsoft.UI.Xaml.Controls;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[EditorBrowsable(EditorBrowsableState.Never)]
public struct PagerControlTemplateSettings
{
    public static IObjectReference CreateMarshaler(global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings obj)
    {
        if (obj is not null)
        {
            return MarshalInspectable<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.CreateMarshaler<IUnknownVftbl>(obj, IPagerControlTemplateSettingsMethods.IID);
        }

        return null;
    }

    public static ObjectReferenceValue CreateMarshaler2(global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings obj)
    {
        return MarshalInspectable<object>.CreateMarshaler2(obj, IPagerControlTemplateSettingsMethods.IID);
    }

    public static IntPtr GetAbi(IObjectReference value)
    {
        if (value != null)
        {
            return MarshalInterfaceHelper<object>.GetAbi(value);
        }

        return IntPtr.Zero;
    }

    public static global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings FromAbi(IntPtr thisPtr)
    {
        return global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings.FromAbi(thisPtr);
    }

    public static IntPtr FromManaged(global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings obj)
    {
        if (obj is not null)
        {
            return CreateMarshaler2(obj).Detach();
        }

        return IntPtr.Zero;
    }

    public static MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.MarshalerArray CreateMarshalerArray(global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings[] array)
    {
        return MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.CreateMarshalerArray2(array, o => CreateMarshaler2(o));
    }

    public static (int length, IntPtr data) GetAbiArray(object box)
    {
        return MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.GetAbiArray(box);
    }

    public static global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings[] FromAbiArray(object box)
    {
        return MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.FromAbiArray(box, FromAbi);
    }

    public static void CopyAbiArray(global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings[] array, object box)
    {
        MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.CopyAbiArray(array, box, FromAbi);
    }

    public static (int length, IntPtr data) FromManagedArray(global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings[] array)
    {
        return MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.FromManagedArray(array, o => FromManaged(o));
    }

    public static void DisposeMarshaler(IObjectReference value)
    {
        MarshalInspectable<object>.DisposeMarshaler(value);
    }

    public static void DisposeMarshalerArray(MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.MarshalerArray array)
    {
        MarshalInterfaceHelper<global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings>.DisposeMarshalerArray(array);
    }

    public static void DisposeAbi(IntPtr abi)
    {
        MarshalInspectable<object>.DisposeAbi(abi);
    }

    public static void DisposeAbiArray(object box)
    {
        MarshalInspectable<object>.DisposeAbiArray(box);
    }
}