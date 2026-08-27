using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;

namespace preAlphaStockControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new DashboardPage());
            SourceInitialized += MainWindow_SourceInitialized;
        }

        private void MainWindow_SourceInitialized(object? sender, EventArgs e)
        {
            var source = (HwndSource)PresentationSource.FromVisual(this)!;
            source.AddHook(WndProc);

            Debug.WriteLine("Window initialized.");
        }

        private IntPtr WndProc(
            IntPtr hwnd,
            int msg,
            IntPtr wParam,
            IntPtr lParam,
            ref bool handled)
        {
            const int WM_DPICHANGED = 0x02E0;

            if (msg == WM_DPICHANGED)
            {
                Debug.WriteLine("===== WM_DPICHANGED RECEIVED =====");

                var dpi = VisualTreeHelper.GetDpi(this);

                Debug.WriteLine($"DPI Scale X : {dpi.DpiScaleX}");
                Debug.WriteLine($"DPI Scale Y : {dpi.DpiScaleY}");
            }

            return IntPtr.Zero;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ThemeMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Change_ThemeMode.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedValue = selectedItem.Content.ToString();

                switch (selectedValue)
                {
                    case "Light":
                        Application.Current.ThemeMode = ThemeMode.Light;
                        break;
                    case "Dark":
                        Application.Current.ThemeMode = ThemeMode.Dark;
                        break;
                    case "Use system setting":
                        Application.Current.ThemeMode = ThemeMode.System;
                        break;
                    default:
                        break;
                }
            }
        }
        private void NavigationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainFrame == null)
                return;

            switch (NavigationList.SelectedIndex)
            {
                case 0:
                    MainFrame.Navigate(new DashboardPage());
                    break;
                case 1:
                    MainFrame.Navigate(new ProductsPage());
                    break;
                case 2:
                    MainFrame.Navigate(new DocumentsPage());
                    break;
                case 3:
                    MainFrame.Navigate(new SuppliersPage());
                    break;
                case 4:
                    MainFrame.Navigate(new RequestersPage());
                    break;
                case 5:
                    MainFrame.Navigate(new ReportsPage());
                    break;
                case 6:
                    MainFrame.Navigate(new SettingsPage());
                    break;
                default:
                    break;
            }
        }
    }
}