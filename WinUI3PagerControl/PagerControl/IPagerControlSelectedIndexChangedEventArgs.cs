using Windows.Foundation.Metadata;
using WinRT;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[global::System.Runtime.InteropServices.Guid("A12A562B-C03A-5F80-A7E5-523311610504")]
[WindowsRuntimeHelperType(typeof(ABI.Microsoft.UI.Xaml.Controls.IPagerControlSelectedIndexChangedEventArgs))]
[ContractVersion(typeof(XamlContract), 589824u)]
internal interface IPagerControlSelectedIndexChangedEventArgs
{
    int NewPageIndex { get; }

    int PreviousPageIndex { get; }
}