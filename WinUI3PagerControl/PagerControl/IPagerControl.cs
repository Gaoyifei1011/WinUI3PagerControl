using Microsoft.UI.Xaml.CustomAttributes;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using WinRT;

namespace Microsoft.UI.Xaml.Controls;

[WindowsRuntimeType("Microsoft.UI.Xaml")]
[global::System.Runtime.InteropServices.Guid("3F2921C3-E09F-5AF1-9055-1D3D3484467F")]
[WindowsRuntimeHelperType(typeof(ABI.Microsoft.UI.Xaml.Controls.IPagerControl))]
[MUXPropertyChangedCallback(enable = true)]
[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
[ContractVersion(typeof(XamlContract), 589824u)]
internal interface IPagerControl
{
    bool ButtonPanelAlwaysShowFirstLastPageIndex { get; set; }

    PagerControlDisplayMode DisplayMode { get; set; }

    ICommand FirstButtonCommand { get; set; }

    Style FirstButtonStyle { get; set; }

    PagerControlButtonVisibility FirstButtonVisibility { get; set; }

    ICommand LastButtonCommand { get; set; }

    Style LastButtonStyle { get; set; }

    PagerControlButtonVisibility LastButtonVisibility { get; set; }

    ICommand NextButtonCommand { get; set; }

    Style NextButtonStyle { get; set; }

    PagerControlButtonVisibility NextButtonVisibility { get; set; }

    int NumberOfPages { get; set; }

    ICommand PagerInputCommand { get; set; }

    string PrefixText { get; set; }

    ICommand PreviousButtonCommand { get; set; }

    Style PreviousButtonStyle { get; set; }

    PagerControlButtonVisibility PreviousButtonVisibility { get; set; }

    int SelectedPageIndex { get; set; }

    string SuffixText { get; set; }

    PagerControlTemplateSettings TemplateSettings { get; }

    event TypedEventHandler<PagerControl, PagerControlSelectedIndexChangedEventArgs> SelectedIndexChanged;
}