using WinRT.GenericTypeInstantiations;

namespace WinRT;

internal sealed unsafe class _EventSource_global__Windows_Foundation_TypedEventHandler_global__Microsoft_UI_Xaml_Controls_PagerControl__global__Microsoft_UI_Xaml_Controls_PagerControlSelectedIndexChangedEventArgs_ : ABI.WinRT.Interop.EventSource<Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.PagerControl, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>>
{
    private static readonly bool initialized = Windows_Foundation_TypedEventHandler_2_Microsoft_UI_Xaml_Controls_PagerControl__Microsoft_UI_Xaml_Controls_PagerControlSelectedIndexChangedEventArgs.EnsureInitialized();

    internal _EventSource_global__Windows_Foundation_TypedEventHandler_global__Microsoft_UI_Xaml_Controls_PagerControl__global__Microsoft_UI_Xaml_Controls_PagerControlSelectedIndexChangedEventArgs_(IObjectReference obj,
    delegate* unmanaged[Stdcall]<nint, nint, EventRegistrationToken*, int> addHandler,
    delegate* unmanaged[Stdcall]<nint, EventRegistrationToken, int> removeHandler, int index) : base(obj, addHandler, removeHandler, index)
    {
        _ = initialized;
    }

    protected override ObjectReferenceValue CreateMarshaler(Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.PagerControl, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs> handler) =>
    ABI.Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.PagerControl, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>.CreateMarshaler2(handler);

    protected override ABI.WinRT.Interop.EventSourceState<Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.PagerControl, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>> CreateEventSourceState() =>
    new EventState(ObjectReference.ThisPtr, Index);

    [WinRTExposedType]
    private sealed class EventState(nint obj, int index) : ABI.WinRT.Interop.EventSourceState<Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.PagerControl, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs>>(obj, index)
    {
        protected override Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.PagerControl, Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs> GetEventInvoke()
        {
            return (sender, args) =>
            {
                var targetDelegate = TargetDelegate;
                if (targetDelegate is null)
                {
                    return;
                }
                targetDelegate.Invoke(sender, args);
            };
        }
    }
}