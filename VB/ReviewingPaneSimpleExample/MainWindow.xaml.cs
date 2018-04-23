#region #usings
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Layout.Core;
using DevExpress.Xpf.RichEdit;
using System.Windows;
#endregion #usings

namespace ReviewingPaneSimpleExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Ribbon.DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DXRibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            #region #CustomizeReviewingPane
            //Access the DockLayoutManager in the template: 
            string name = RichEditControl.DockLayoutManagerName;
            DockLayoutManager manager = (DockLayoutManager)richEdit.Template.FindName(name, richEdit);

            //Retireve the Reviewing Pane 
            LayoutPanel commentPanel = manager.LayoutRoot.Items[0] as LayoutPanel;
            DocumentPanel documentPanel = manager.LayoutRoot.Items[1] as DocumentPanel;

            //Dock panel to the right 
            manager.DockController.Dock(commentPanel, documentPanel, DockType.Right);

            //Hide the pane to the tab 
            commentPanel.AutoHidden = true;

            //Disable floating 
            commentPanel.AllowFloat = false;
            #endregion #CustomizeReviewingPane
        }
    }
}
