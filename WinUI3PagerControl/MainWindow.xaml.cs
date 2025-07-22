using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System.Collections.Specialized;
using System.ComponentModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3PagerControl
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ComboBox pagerComboBox;
        NumberBox pagerNumberBox;
        ItemsRepeater pagerItemsRepeater;

        Button firstPageButton;
        Button previousPageButton;
        Button nextPageButton;
        Button lastPageButton;

        private int selectedPageIndex;

        public int SelectedPageIndex
        {
            get { return selectedPageIndex; }
            set
            {
                selectedPageIndex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((nameof(SelectedPageIndex))));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnLoad(object sender, RoutedEventArgs args)
        {
            PagerDisplayModeComboBox.SelectionChanged += OnDisplayModeChanged;
            FirstPageButtonVisibilityComboBox.SelectionChanged += OnFirstButtonVisibilityChanged;
            PreviousPageButtonVisibilityComboBox.SelectionChanged += OnPreviousButtonVisibilityChanged;
            NextPageButtonVisibilityComboBox.SelectionChanged += OnNextButtonVisibilityChanged;
            LastPageButtonVisibilityComboBox.SelectionChanged += OnLastButtonVisibilityChanged;

            var rootGrid = VisualTreeHelper.GetChild(TestPager, 0);
            var backButtonsPanel = VisualTreeHelper.GetChild(rootGrid, 0);
            firstPageButton = VisualTreeHelper.GetChild(backButtonsPanel, 0) as Button;
            previousPageButton = VisualTreeHelper.GetChild(backButtonsPanel, 1) as Button;

            var boxPanels = VisualTreeHelper.GetChild(rootGrid, 1);
            pagerNumberBox = VisualTreeHelper.GetChild(boxPanels, 1) as NumberBox;
            pagerComboBox = VisualTreeHelper.GetChild(boxPanels, 2) as ComboBox;
            pagerItemsRepeater = VisualTreeHelper.GetChild(rootGrid, 2) as ItemsRepeater;

            var forwardButtonsPanel = VisualTreeHelper.GetChild(rootGrid, 4);
            nextPageButton = VisualTreeHelper.GetChild(forwardButtonsPanel, 0) as Button;
            lastPageButton = VisualTreeHelper.GetChild(forwardButtonsPanel, 1) as Button;

            NumberBoxVisibilityCheckBox.IsChecked = pagerNumberBox.Visibility == Visibility.Visible;
            ComboBoxVisibilityCheckBox.IsChecked = pagerComboBox.Visibility == Visibility.Visible;
            NumberPanelVisibilityCheckBox.IsChecked = pagerItemsRepeater.Visibility == Visibility.Visible;
            NumberBoxIsEnabledCheckBox.IsChecked = pagerNumberBox.IsEnabled;
            ComboBoxIsEnabledCheckBox.IsChecked = pagerComboBox.IsEnabled;

            FirstPageButtonVisibilityCheckBox.IsChecked = firstPageButton?.Visibility == Visibility.Visible && firstPageButton?.Opacity != 0;
            PreviousPageButtonVisibilityCheckBox.IsChecked = previousPageButton?.Visibility == Visibility.Visible && previousPageButton?.Opacity != 0;
            NextPageButtonVisibilityCheckBox.IsChecked = nextPageButton?.Visibility == Visibility.Visible && nextPageButton?.Opacity != 0;
            LastPageButtonVisibilityCheckBox.IsChecked = lastPageButton?.Visibility == Visibility.Visible && lastPageButton?.Opacity != 0;

            FirstPageButtonIsEnabledCheckBox.IsChecked = firstPageButton?.IsEnabled;
            PreviousPageButtonIsEnabledCheckBox.IsChecked = previousPageButton?.IsEnabled;
            NextPageButtonIsEnabledCheckBox.IsChecked = nextPageButton?.IsEnabled;
            LastPageButtonIsEnabledCheckBox.IsChecked = lastPageButton?.IsEnabled;
            UpdateNumberPanelContentTextBlock(this, null);
        }

        private void UpdateNumberPanelContentTextBlock(object sender, NotifyCollectionChangedEventArgs args)
        {
            NumberPanelContentTextBlock.Text = "";
            foreach (var item in TestPager.TemplateSettings.NumberPanelItems)
            {
                if (item.GetType() == typeof(SymbolIcon))
                {
                    NumberPanelContentTextBlock.Text += (item as SymbolIcon).Symbol;
                }
                else if (item.GetType() == typeof(Button))
                {
                    NumberPanelContentTextBlock.Text += (item as Button).Content;
                }
            }
        }

        private void NumberOfPagesSetterButtonClicked(object sender, RoutedEventArgs args)
        {
            if (TestPager.NumberOfPages == 5)
            {
                TestPager.NumberOfPages = 100;
                NumberOfPagesSetterButton.Content = "Set NumberOfPages to 5";
            }
            else
            {
                TestPager.NumberOfPages = 5;
                NumberOfPagesSetterButton.Content = "Set NumberOfPages to 100";
            }

            NumberBoxVisibilityCheckBox.IsChecked = pagerNumberBox?.Visibility == Visibility.Visible;
            ComboBoxVisibilityCheckBox.IsChecked = pagerComboBox?.Visibility == Visibility.Visible;
            NumberPanelVisibilityCheckBox.IsChecked = pagerItemsRepeater?.Visibility == Visibility.Visible;
            NumberBoxIsEnabledCheckBox.IsChecked = pagerNumberBox?.IsEnabled;
            ComboBoxIsEnabledCheckBox.IsChecked = pagerComboBox?.IsEnabled;
        }

        private void NumberOfPagesInfinityButtonClicked(object sender, RoutedEventArgs args)
        {
            TestPager.NumberOfPages = -1;

            NumberBoxVisibilityCheckBox.IsChecked = pagerNumberBox?.Visibility == Visibility.Visible;
            ComboBoxVisibilityCheckBox.IsChecked = pagerComboBox?.Visibility == Visibility.Visible;
            NumberPanelVisibilityCheckBox.IsChecked = pagerItemsRepeater?.Visibility == Visibility.Visible;
            NumberBoxIsEnabledCheckBox.IsChecked = pagerNumberBox?.IsEnabled;
            ComboBoxIsEnabledCheckBox.IsChecked = pagerComboBox?.IsEnabled;
        }

        private void IncreaseNumberOfPagesButtonClicked(object sender, RoutedEventArgs args)
        {
            TestPager.NumberOfPages += 1;

            NumberBoxVisibilityCheckBox.IsChecked = pagerNumberBox?.Visibility == Visibility.Visible;
            ComboBoxVisibilityCheckBox.IsChecked = pagerComboBox?.Visibility == Visibility.Visible;
            NumberPanelVisibilityCheckBox.IsChecked = pagerItemsRepeater?.Visibility == Visibility.Visible;
            NumberBoxIsEnabledCheckBox.IsChecked = pagerNumberBox?.IsEnabled;
            ComboBoxIsEnabledCheckBox.IsChecked = pagerComboBox?.IsEnabled;
        }

        private void CheckIfButtonsHiddenButtonClicked(object sender, RoutedEventArgs args)
        {
            var rootGrid = VisualTreeHelper.GetChild(TemplateButtonVisibilitySetPager, 0);
            var backButtonsPanel = VisualTreeHelper.GetChild(rootGrid, 0);
            var firstPageButtonTemplatePager = VisualTreeHelper.GetChild(backButtonsPanel, 0) as Button;
            var previousPageButtonTemplatePager = VisualTreeHelper.GetChild(backButtonsPanel, 1) as Button;

            var forwardButtonsPanel = VisualTreeHelper.GetChild(rootGrid, 4);
            var nextPageButtonTemplatePager = VisualTreeHelper.GetChild(forwardButtonsPanel, 0) as Button;
            var lastPageButtonTemplatePager = VisualTreeHelper.GetChild(forwardButtonsPanel, 1) as Button;

            int violationCount = 0;
            violationCount += (firstPageButtonTemplatePager?.Visibility == Visibility.Collapsed || firstPageButton?.Opacity == 0) ? 0 : 1;
            violationCount += (previousPageButtonTemplatePager?.Visibility == Visibility.Collapsed || previousPageButton?.Opacity == 0) ? 0 : 1;
            violationCount += (nextPageButtonTemplatePager?.Visibility == Visibility.Collapsed || nextPageButton?.Opacity == 0) ? 0 : 1;
            violationCount += (lastPageButtonTemplatePager?.Visibility == Visibility.Collapsed || lastPageButton?.Opacity == 0) ? 0 : 1;

            CheckIfButtonsHiddenLabel.Text = violationCount == 0 ? "Passed" : "Failed";
        }

        private void OnSelectedIndexChanged(PagerControl sender, PagerControlSelectedIndexChangedEventArgs args)
        {
            UpdateNumberPanelContentTextBlock(this, null);
            PreviousPageTextBlock.Text = args.PreviousPageIndex.ToString();
            CurrentPageTextBlock.Text = args.NewPageIndex.ToString();

            FirstPageButtonVisibilityCheckBox.IsChecked = firstPageButton?.Visibility == Visibility.Visible && firstPageButton?.Opacity != 0;
            PreviousPageButtonVisibilityCheckBox.IsChecked = previousPageButton?.Visibility == Visibility.Visible && previousPageButton?.Opacity != 0;
            NextPageButtonVisibilityCheckBox.IsChecked = nextPageButton?.Visibility == Visibility.Visible && nextPageButton?.Opacity != 0;
            LastPageButtonVisibilityCheckBox.IsChecked = lastPageButton?.Visibility == Visibility.Visible && lastPageButton?.Opacity != 0;

            FirstPageButtonIsEnabledCheckBox.IsChecked = firstPageButton?.IsEnabled;
            PreviousPageButtonIsEnabledCheckBox.IsChecked = previousPageButton?.IsEnabled;
            NextPageButtonIsEnabledCheckBox.IsChecked = nextPageButton?.IsEnabled;
            LastPageButtonIsEnabledCheckBox.IsChecked = lastPageButton?.IsEnabled;
        }

        private void OnDisplayModeChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = PagerDisplayModeComboBox.SelectedItem as ComboBoxItem;

            if (item == AutoDisplayModeItem)
            {
                TestPager.DisplayMode = PagerControlDisplayMode.Auto;
                CustomizedPager.DisplayMode = PagerControlDisplayMode.Auto;
            }
            else if (item == NumberBoxDisplayModeItem)
            {
                TestPager.DisplayMode = PagerControlDisplayMode.NumberBox;
                CustomizedPager.DisplayMode = PagerControlDisplayMode.NumberBox;
            }
            else if (item == ComboBoxDisplayModeItem)
            {
                TestPager.DisplayMode = PagerControlDisplayMode.ComboBox;
                CustomizedPager.DisplayMode = PagerControlDisplayMode.ComboBox;
            }
            else if (item == NumberPanelDisplayModeItem)
            {
                TestPager.DisplayMode = PagerControlDisplayMode.ButtonPanel;
                CustomizedPager.DisplayMode = PagerControlDisplayMode.ButtonPanel;
            }

            NumberBoxVisibilityCheckBox.IsChecked = pagerNumberBox?.Visibility == Visibility.Visible;
            ComboBoxVisibilityCheckBox.IsChecked = pagerComboBox?.Visibility == Visibility.Visible;
            NumberPanelVisibilityCheckBox.IsChecked = pagerItemsRepeater?.Visibility == Visibility.Visible;
            NumberBoxIsEnabledCheckBox.IsChecked = pagerNumberBox?.IsEnabled;
            ComboBoxIsEnabledCheckBox.IsChecked = pagerComboBox?.IsEnabled;
        }

        private void OnFirstButtonVisibilityChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = FirstPageButtonVisibilityComboBox.SelectedItem as ComboBoxItem;

            if (item == NoneFirstPageButtonVisibilityItem)
            {
                TestPager.FirstButtonVisibility = PagerControlButtonVisibility.Hidden;
            }
            else if (item == AlwaysVisibleFirstPageButtonVisibilityItem)
            {
                TestPager.FirstButtonVisibility = PagerControlButtonVisibility.Visible;
            }
            else if (item == HiddenOnEdgeFirstPageButtonVisibilityItem)
            {
                TestPager.FirstButtonVisibility = PagerControlButtonVisibility.HiddenOnEdge;
            }

            FirstPageButtonVisibilityCheckBox.IsChecked = firstPageButton?.Visibility == Visibility.Visible && firstPageButton?.Opacity != 0;
        }

        private void OnPreviousButtonVisibilityChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = PreviousPageButtonVisibilityComboBox.SelectedItem as ComboBoxItem;

            if (item == NonePreviousPageButtonVisibilityItem)
            {
                TestPager.PreviousButtonVisibility = PagerControlButtonVisibility.Hidden;
            }
            else if (item == AlwaysVisiblePreviousPageButtonVisibilityItem)
            {
                TestPager.PreviousButtonVisibility = PagerControlButtonVisibility.Visible;
            }
            else if (item == HiddenOnEdgePreviousPageButtonVisibilityItem)
            {
                TestPager.PreviousButtonVisibility = PagerControlButtonVisibility.HiddenOnEdge;
            }

            PreviousPageButtonVisibilityCheckBox.IsChecked = previousPageButton?.Visibility == Visibility.Visible && previousPageButton?.Opacity != 0;
        }

        private void OnNextButtonVisibilityChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = NextPageButtonVisibilityComboBox.SelectedItem as ComboBoxItem;

            if (item == NoneNextPageButtonVisibilityItem)
            {
                TestPager.NextButtonVisibility = PagerControlButtonVisibility.Hidden;
            }
            else if (item == AlwaysVisibleNextPageButtonVisibilityItem)
            {
                TestPager.NextButtonVisibility = PagerControlButtonVisibility.Visible;
            }
            else if (item == HiddenOnEdgeNextPageButtonVisibilityItem)
            {
                TestPager.NextButtonVisibility = PagerControlButtonVisibility.HiddenOnEdge;
            }

            NextPageButtonVisibilityCheckBox.IsChecked = nextPageButton?.Visibility == Visibility.Visible && nextPageButton?.Opacity != 0;
        }

        private void OnLastButtonVisibilityChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = LastPageButtonVisibilityComboBox.SelectedItem as ComboBoxItem;

            if (item == NoneLastPageButtonVisibilityItem)
            {
                TestPager.LastButtonVisibility = PagerControlButtonVisibility.Hidden;
            }
            else if (item == AlwaysVisibleLastPageButtonVisibilityItem)
            {
                TestPager.LastButtonVisibility = PagerControlButtonVisibility.Visible;
            }
            else if (item == HiddenOnEdgeLastPageButtonVisibilityItem)
            {
                TestPager.LastButtonVisibility = PagerControlButtonVisibility.HiddenOnEdge;
            }

            LastPageButtonVisibilityCheckBox.IsChecked = lastPageButton?.Visibility == Visibility.Visible && lastPageButton?.Opacity != 0;
        }
    }
}