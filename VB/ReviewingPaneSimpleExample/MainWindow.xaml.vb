#Region "#usings"
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Layout.Core
Imports DevExpress.Xpf.RichEdit
Imports System.Windows
#End Region ' #usings

Namespace ReviewingPaneSimpleExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DevExpress.Xpf.Ribbon.DXRibbonWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DXRibbonWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
'            #Region "#CustomizeReviewingPane"
            'Access the DockLayoutManager in the template: 
            Dim name As String = RichEditControl.DockLayoutManagerName
            Dim manager As DockLayoutManager = CType(richEdit.Template.FindName(name, richEdit), DockLayoutManager)

            'Retireve the Reviewing Pane 
            Dim commentPanel As LayoutPanel = TryCast(manager.LayoutRoot.Items(0), LayoutPanel)
            Dim documentPanel As DocumentPanel = TryCast(manager.LayoutRoot.Items(1), DocumentPanel)

            'Dock panel to the right 
            manager.DockController.Dock(commentPanel, documentPanel, DockType.Right)

            'Hide the pane to the tab 
            commentPanel.AutoHidden = True

            'Disable floating 
            commentPanel.AllowFloat = False
'            #End Region ' #CustomizeReviewingPane
        End Sub
    End Class
End Namespace
