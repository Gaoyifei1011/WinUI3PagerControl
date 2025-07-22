using ABI.Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Threading;
using Windows.Foundation.Metadata;
using WinRT;
using WinRT.Interop;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[WindowsRuntimeHelperType(typeof(ABI.Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs))]
[PagerControlSelectedIndexChangedEventArgsRcwFactory]
[ProjectedRuntimeClass(typeof(IPagerControlSelectedIndexChangedEventArgs))]
[ContractVersion(typeof(XamlContract), 589824u)]
public sealed class PagerControlSelectedIndexChangedEventArgs : ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<PagerControlSelectedIndexChangedEventArgs>
{
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    private struct InterfaceTag<I>
    {
    }

    private readonly IObjectReference _inner;

    private volatile ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> _queryInterfaceCache;

    private volatile ConcurrentDictionary<RuntimeTypeHandle, object> _additionalTypeData;

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

    private IObjectReference _objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlSelectedIndexChangedEventArgs => _inner;

    bool IWinRTObject.HasUnwrappableNativeObject => true;

    IObjectReference IWinRTObject.NativeObject => _inner;

    ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> IWinRTObject.QueryInterfaceCache => _queryInterfaceCache ?? MakeQueryInterfaceCache();

    ConcurrentDictionary<RuntimeTypeHandle, object> IWinRTObject.AdditionalTypeData => _additionalTypeData ?? MakeAdditionalTypeData();

    public int NewPageIndex => IPagerControlSelectedIndexChangedEventArgsMethods.get_NewPageIndex(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlSelectedIndexChangedEventArgs);

    public int PreviousPageIndex => IPagerControlSelectedIndexChangedEventArgsMethods.get_PreviousPageIndex(_objRef_global__Microsoft_UI_Xaml_Controls_IPagerControlSelectedIndexChangedEventArgs);

    public static PagerControlSelectedIndexChangedEventArgs FromAbi(IntPtr thisPtr)
    {
        if (thisPtr == IntPtr.Zero)
        {
            return null;
        }

        return MarshalInspectable<PagerControlSelectedIndexChangedEventArgs>.FromAbi(thisPtr);
    }

    internal PagerControlSelectedIndexChangedEventArgs(IObjectReference objRef)
    {
        _inner = objRef.As(IPagerControlSelectedIndexChangedEventArgsMethods.IID);
    }

    public static bool operator ==(PagerControlSelectedIndexChangedEventArgs x, PagerControlSelectedIndexChangedEventArgs y)
    {
        return (x?.ThisPtr ?? IntPtr.Zero) == (y?.ThisPtr ?? IntPtr.Zero);
    }

    public static bool operator !=(PagerControlSelectedIndexChangedEventArgs x, PagerControlSelectedIndexChangedEventArgs y)
    {
        return !(x == y);
    }

    public bool Equals(PagerControlSelectedIndexChangedEventArgs other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        if (obj is PagerControlSelectedIndexChangedEventArgs pagerControlSelectedIndexChangedEventArgs)
        {
            return this == pagerControlSelectedIndexChangedEventArgs;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ThisPtr.GetHashCode();
    }

    private ConcurrentDictionary<RuntimeTypeHandle, IObjectReference> MakeQueryInterfaceCache()
    {
        Interlocked.CompareExchange(ref _queryInterfaceCache, new ConcurrentDictionary<RuntimeTypeHandle, IObjectReference>(), null);
        return _queryInterfaceCache;
    }

    private ConcurrentDictionary<RuntimeTypeHandle, object> MakeAdditionalTypeData()
    {
        Interlocked.CompareExchange(ref _additionalTypeData, new ConcurrentDictionary<RuntimeTypeHandle, object>(), null);
        return _additionalTypeData;
    }

    private bool IsOverridableInterface(Guid iid)
    {
        return false;
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