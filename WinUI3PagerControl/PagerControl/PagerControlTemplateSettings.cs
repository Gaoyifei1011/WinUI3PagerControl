using ABI.Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Windows.Foundation.Metadata;
using WinRT;
using WinRT.Interop;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[WindowsRuntimeHelperType(typeof(ABI.Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings))]
[PagerControlTemplateSettingsRcwFactory]
[ProjectedRuntimeClass(typeof(IPagerControlTemplateSettings))]
[MUXPropertyNeedsDependencyPropertyField]
[ContractVersion(typeof(XamlContract), 589824u)]
public class PagerControlTemplateSettings : DependencyObject, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<PagerControlTemplateSettings>
{
    private static class _IPagerControlTemplateSettingsFactoryMethods
    {
        public static unsafe IntPtr CreateInstance(IObjectReference _obj, object baseInterface, out IntPtr innerInterface)
        {
            IntPtr thisPtr = _obj.ThisPtr;
            ObjectReferenceValue value = default;
            IntPtr intPtr = default;
            IntPtr result = default;
            try
            {
                value = MarshalInspectable<object>.CreateMarshaler2(baseInterface);
                ExceptionHelpers.ThrowExceptionForHR(((delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>)(*(IntPtr*)((*(IntPtr*)(void*)thisPtr) + 6 * (nint)sizeof(delegate* unmanaged[Stdcall]<IntPtr, IntPtr, IntPtr*, IntPtr*, int>))))(thisPtr, MarshalInspectable<object>.GetAbi(value), &intPtr, &result));
                innerInterface = intPtr;
                return result;
            }
            finally
            {
                MarshalInspectable<object>.DisposeMarshaler(value);
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    private struct InterfaceTag<I>
    {
    }

    private readonly IObjectReference _inner;

    private volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings;

    private static volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory;

    private IntPtr ThisPtr
    {
        get
        {
            if (_inner != null)
            {
                return _inner.ThisPtr;
            }

            return ((IWinRTObject)this).NativeObject.ThisPtr;
        }
    }

    private IObjectReference _objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings => ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings ?? Make___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings();

    private static IObjectReference _objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory
    {
        get
        {
            IObjectReference __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory = ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory;
            if (__objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory != null && __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory.IsInCurrentContext)
            {
                return __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory;
            }

            return ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory = ActivationFactory.Get("Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings", IPagerControlTemplateSettingsFactoryMethods.IID);
        }
    }

    bool IWinRTObject.HasUnwrappableNativeObject => GetType() == typeof(PagerControlTemplateSettings);

    IObjectReference IWinRTObject.NativeObject => _inner;

    public IList<object> NumberPanelItems => IPagerControlTemplateSettingsMethods.get_NumberPanelItems(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings);

    public IList<object> Pages => IPagerControlTemplateSettingsMethods.get_Pages(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings);

    private IObjectReference Make___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings()
    {
        Interlocked.CompareExchange(ref ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings, ((IWinRTObject)this).NativeObject.As<IUnknownVftbl>(IPagerControlTemplateSettingsMethods.IID), null);
        return ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettings;
    }

    public PagerControlTemplateSettings()
        : base(DerivedComposed.Instance)
    {
        bool flag = GetType() != typeof(PagerControlTemplateSettings);
        IntPtr newInstance = _IPagerControlTemplateSettingsFactoryMethods.CreateInstance(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlTemplateSettingsFactory, flag ? this : null, out nint innerInterface);
        try
        {
            ComWrappersHelper.Init(flag, this, newInstance, innerInterface, IPagerControlTemplateSettingsMethods.IID, out _inner);
        }
        finally
        {
            Marshal.Release(innerInterface);
        }
    }

    public new static PagerControlTemplateSettings FromAbi(IntPtr thisPtr)
    {
        if (thisPtr == IntPtr.Zero)
        {
            return null;
        }

        return MarshalInspectable<PagerControlTemplateSettings>.FromAbi(thisPtr);
    }

    protected internal PagerControlTemplateSettings(IObjectReference objRef)
        : base(DerivedComposed.Instance)
    {
        _inner = objRef.As(IPagerControlTemplateSettingsMethods.IID);
    }

    public static bool operator ==(PagerControlTemplateSettings x, PagerControlTemplateSettings y)
    {
        return (x?.ThisPtr ?? IntPtr.Zero) == (y?.ThisPtr ?? IntPtr.Zero);
    }

    public static bool operator !=(PagerControlTemplateSettings x, PagerControlTemplateSettings y)
    {
        return !(x == y);
    }

    public bool Equals(PagerControlTemplateSettings other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is PagerControlTemplateSettings pagerControlTemplateSettings)
        {
            return this == pagerControlTemplateSettings;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ThisPtr.GetHashCode();
    }

    protected PagerControlTemplateSettings(DerivedComposed _)
        : base(_)
    {
    }

    protected override bool IsOverridableInterface(Guid iid)
    {
        return base.IsOverridableInterface(iid);
    }

    CustomQueryInterfaceResult ICustomQueryInterface.GetInterface(ref Guid iid, out IntPtr ppv)
    {
        ppv = IntPtr.Zero;
        if (IsOverridableInterface(iid) || IID.IID_IInspectable == iid)
        {
            return CustomQueryInterfaceResult.NotHandled;
        }

        if (((IWinRTObject)this).NativeObject.TryAs(iid, out ppv) >= 0)
        {
            return CustomQueryInterfaceResult.Handled;
        }

        return CustomQueryInterfaceResult.NotHandled;
    }
}