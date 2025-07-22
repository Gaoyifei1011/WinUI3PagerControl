using Windows.Foundation.Metadata;
using WinRT;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[WinRTExposedType(typeof(EnumTypeDetails<PagerControlButtonVisibility>))]
[ContractVersion(typeof(XamlContract), 589824u)]
public enum PagerControlButtonVisibility
{
    Visible,
    HiddenOnEdge,
    Hidden
}