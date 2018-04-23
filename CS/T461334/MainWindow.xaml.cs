using System.Diagnostics;
using System.Windows;
using DevExpress.Xpf.Reports.UserDesigner;

namespace T461334 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            designer.Commands = new CustomDesignerCommands();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            designer.OpenDocument(new SampleReport());
        }
    }

    public class CustomDesignerCommands : ReportDesignerCommands {
        protected override void SaveDocumentAs() {
            Debug.WriteLine("CustomDesignerCommands.SaveDocumentAs");
            base.SaveDocumentAs();
        }
    }
}
