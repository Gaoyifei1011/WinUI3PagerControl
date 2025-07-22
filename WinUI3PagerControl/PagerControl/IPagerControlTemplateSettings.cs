using Microsoft.UI.Xaml.CustomAttributes;
using System.Collections.Generic;
using Windows.Foundation.Metadata;
using WinRT;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[global::System.Runtime.InteropServices.Guid("F4A16613-0345-5841-B51A-227310797727")]
[WindowsRuntimeHelperType(typeof(ABI.Microsoft.UI.Xaml.Controls.IPagerControlTemplateSettings))]
[MUXPropertyNeedsDependencyPropertyField]
[ContractVersion(typeof(XamlContract), 589824u)]
internal interface IPagerControlTemplateSettings
{
    IList<object> NumberPanelItems { get; }

    IList<object> Pages { get; }
}