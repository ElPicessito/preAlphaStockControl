using System;
using System.Diagnostics;
using System.Windows;
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

            // Appelé une fois que la fenêtre possède un handle Windows
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
    }
}