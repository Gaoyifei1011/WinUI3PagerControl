using System.ComponentModel;
using WinRT;

namespace ABI.Microsoft.UI.Xaml.Controls;

[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class PagerControlTemplateSettingsRcwFactoryAttribute : WinRTImplementationTypeRcwFactoryAttribute
{
    public override object CreateInstance(IInspectable inspectable)
    {
        return new global::Microsoft.UI.Xaml.Controls.PagerControlTemplateSettings(inspectable.ObjRef);
    }
}