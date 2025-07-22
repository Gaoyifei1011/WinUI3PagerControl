using System.ComponentModel;
using WinRT;

namespace ABI.Microsoft.UI.Xaml.Controls;

[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class PagerControlSelectedIndexChangedEventArgsRcwFactoryAttribute : WinRTImplementationTypeRcwFactoryAttribute
{
    public override object CreateInstance(IInspectable inspectable)
    {
        return new global::Microsoft.UI.Xaml.Controls.PagerControlSelectedIndexChangedEventArgs(inspectable.ObjRef);
    }
}