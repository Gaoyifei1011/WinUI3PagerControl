using Windows.Foundation.Metadata;
using WinRT;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[WinRTExposedType(typeof(EnumTypeDetails<PagerControlDisplayMode>))]
[ContractVersion(typeof(XamlContract), 589824u)]
public enum PagerControlDisplayMode
{
    Auto,
    ComboBox,
    NumberBox,
    ButtonPanel
}