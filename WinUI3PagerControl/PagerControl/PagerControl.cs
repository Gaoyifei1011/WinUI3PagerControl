using ABI.Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.CustomAttributes;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using WinRT;
using WinRT.Interop;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[WindowsRuntimeHelperType(typeof(ABI.Microsoft.UI.Xaml.Controls.PagerControl))]
[PagerControlRcwFactory]
[ProjectedRuntimeClass(typeof(IPagerControl))]
[MUXPropertyChangedCallback(enable = true)]
[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
[ContractVersion(typeof(XamlContract), 589824u)]
public class PagerControl : Control, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<PagerControl>
{
    private static class _IPagerControlFactoryMethods
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

    private volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl;

    private static volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory;

    private static volatile IObjectReference ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics;

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

    private IObjectReference _objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl => ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl ?? Make___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl();

    private static IObjectReference _objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory
    {
        get
        {
            IObjectReference __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory = ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory;
            if (__objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory != null && __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory.IsInCurrentContext)
            {
                return __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory;
            }

            return ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory = ActivationFactory.Get("Microsoft.UI.Xaml.Controls.PagerControl", IPagerControlFactoryMethods.IID);
        }
    }

    private static IObjectReference _objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics
    {
        get
        {
            IObjectReference __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics = ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics;
            if (__objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics != null && __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics.IsInCurrentContext)
            {
                return __objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics;
            }

            return ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics = ActivationFactory.Get("Microsoft.UI.Xaml.Controls.PagerControl", IPagerControlStaticsMethods.IID);
        }
    }

    public static DependencyProperty ButtonPanelAlwaysShowFirstLastPageIndexProperty => IPagerControlStaticsMethods.get_ButtonPanelAlwaysShowFirstLastPageIndexProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty DisplayModeProperty => IPagerControlStaticsMethods.get_DisplayModeProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty FirstButtonCommandProperty => IPagerControlStaticsMethods.get_FirstButtonCommandProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty FirstButtonStyleProperty => IPagerControlStaticsMethods.get_FirstButtonStyleProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty FirstButtonVisibilityProperty => IPagerControlStaticsMethods.get_FirstButtonVisibilityProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty LastButtonCommandProperty => IPagerControlStaticsMethods.get_LastButtonCommandProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty LastButtonStyleProperty => IPagerControlStaticsMethods.get_LastButtonStyleProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty LastButtonVisibilityProperty => IPagerControlStaticsMethods.get_LastButtonVisibilityProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty NextButtonCommandProperty => IPagerControlStaticsMethods.get_NextButtonCommandProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty NextButtonStyleProperty => IPagerControlStaticsMethods.get_NextButtonStyleProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty NextButtonVisibilityProperty => IPagerControlStaticsMethods.get_NextButtonVisibilityProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty NumberOfPagesProperty => IPagerControlStaticsMethods.get_NumberOfPagesProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty PagerInputCommandProperty => IPagerControlStaticsMethods.get_PagerInputCommandProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty PrefixTextProperty => IPagerControlStaticsMethods.get_PrefixTextProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty PreviousButtonCommandProperty => IPagerControlStaticsMethods.get_PreviousButtonCommandProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty PreviousButtonStyleProperty => IPagerControlStaticsMethods.get_PreviousButtonStyleProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty PreviousButtonVisibilityProperty => IPagerControlStaticsMethods.get_PreviousButtonVisibilityProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty SelectedPageIndexProperty => IPagerControlStaticsMethods.get_SelectedPageIndexProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    public static DependencyProperty SuffixTextProperty => IPagerControlStaticsMethods.get_SuffixTextProperty(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlStatics);

    bool IWinRTObject.HasUnwrappableNativeObject => GetType() == typeof(PagerControl);

    IObjectReference IWinRTObject.NativeObject => _inner;

    public bool ButtonPanelAlwaysShowFirstLastPageIndex
    {
        get
        {
            return IPagerControlMethods.get_ButtonPanelAlwaysShowFirstLastPageIndex(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_ButtonPanelAlwaysShowFirstLastPageIndex(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public PagerControlDisplayMode DisplayMode
    {
        get
        {
            return IPagerControlMethods.get_DisplayMode(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_DisplayMode(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public ICommand FirstButtonCommand
    {
        get
        {
            return IPagerControlMethods.get_FirstButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_FirstButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public Style FirstButtonStyle
    {
        get
        {
            return IPagerControlMethods.get_FirstButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_FirstButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public PagerControlButtonVisibility FirstButtonVisibility
    {
        get
        {
            return IPagerControlMethods.get_FirstButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_FirstButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public ICommand LastButtonCommand
    {
        get
        {
            return IPagerControlMethods.get_LastButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_LastButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public Style LastButtonStyle
    {
        get
        {
            return IPagerControlMethods.get_LastButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_LastButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public PagerControlButtonVisibility LastButtonVisibility
    {
        get
        {
            return IPagerControlMethods.get_LastButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_LastButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public ICommand NextButtonCommand
    {
        get
        {
            return IPagerControlMethods.get_NextButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_NextButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public Style NextButtonStyle
    {
        get
        {
            return IPagerControlMethods.get_NextButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_NextButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public PagerControlButtonVisibility NextButtonVisibility
    {
        get
        {
            return IPagerControlMethods.get_NextButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_NextButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public int NumberOfPages
    {
        get
        {
            return IPagerControlMethods.get_NumberOfPages(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_NumberOfPages(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public ICommand PagerInputCommand
    {
        get
        {
            return IPagerControlMethods.get_PagerInputCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_PagerInputCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public string PrefixText
    {
        get
        {
            return IPagerControlMethods.get_PrefixText(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_PrefixText(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public ICommand PreviousButtonCommand
    {
        get
        {
            return IPagerControlMethods.get_PreviousButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_PreviousButtonCommand(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public Style PreviousButtonStyle
    {
        get
        {
            return IPagerControlMethods.get_PreviousButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_PreviousButtonStyle(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public PagerControlButtonVisibility PreviousButtonVisibility
    {
        get
        {
            return IPagerControlMethods.get_PreviousButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_PreviousButtonVisibility(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public int SelectedPageIndex
    {
        get
        {
            return IPagerControlMethods.get_SelectedPageIndex(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_SelectedPageIndex(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public string SuffixText
    {
        get
        {
            return IPagerControlMethods.get_SuffixText(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);
        }
        set
        {
            IPagerControlMethods.set_SuffixText(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, value);
        }
    }

    public PagerControlTemplateSettings TemplateSettings => IPagerControlMethods.get_TemplateSettings(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl);

    public event TypedEventHandler<PagerControl, PagerControlSelectedIndexChangedEventArgs> SelectedIndexChanged
    {
        add
        {
            IPagerControlMethods.Get_SelectedIndexChanged2(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, this).Subscribe(value);
        }
        remove
        {
            IPagerControlMethods.Get_SelectedIndexChanged2(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, this).Unsubscribe(value);
        }
    }

    private IObjectReference Make___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl()
    {
        Interlocked.CompareExchange(ref ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl, ((IWinRTObject)this).NativeObject.As<IUnknownVftbl>(IPagerControlMethods.IID), null);
        return ___objRef_global__Microsoft_UI_Xaml_Controls_IPagerControl;
    }

    public PagerControl()
        : base(DerivedComposed.Instance)
    {
        bool flag = GetType() != typeof(PagerControl);
        IntPtr newInstance = _IPagerControlFactoryMethods.CreateInstance(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlFactory, flag ? this : null, out nint innerInterface);
        try
        {
            ComWrappersHelper.Init(flag, this, newInstance, innerInterface, IPagerControlMethods.IID, out _inner);
        }
        finally
        {
            Marshal.Release(innerInterface);
        }
    }

    public new static I As<I>()
    {
        return ActivationFactory.Get("Microsoft.UI.Xaml.Controls.PagerControl").AsInterface<I>();
    }

    public new static PagerControl FromAbi(IntPtr thisPtr)
    {
        if (thisPtr == IntPtr.Zero)
        {
            return null;
        }

        return MarshalInspectable<PagerControl>.FromAbi(thisPtr);
    }

    protected internal PagerControl(IObjectReference objRef)
        : base(DerivedComposed.Instance)
    {
        _inner = objRef.As(IPagerControlMethods.IID);
    }

    public static bool operator ==(PagerControl x, PagerControl y)
    {
        return (x?.ThisPtr ?? IntPtr.Zero) == (y?.ThisPtr ?? IntPtr.Zero);
    }

    public static bool operator !=(PagerControl x, PagerControl y)
    {
        return !(x == y);
    }

    public bool Equals(PagerControl other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is PagerControl pagerControl)
        {
            return this == pagerControl;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ThisPtr.GetHashCode();
    }

    protected PagerControl(DerivedComposed _)
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