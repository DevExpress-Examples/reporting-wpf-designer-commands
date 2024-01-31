Imports System.Diagnostics
Imports System.Windows
Imports DevExpress.Xpf.Reports.UserDesigner

Namespace T461334

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.designer.Commands = New CustomDesignerCommands()
            AddHandler Loaded, AddressOf Me.MainWindow_Loaded
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.designer.OpenDocument(New SampleReport())
        End Sub
    End Class

    Public Class CustomDesignerCommands
        Inherits ReportDesignerCommands

        Protected Overrides Sub SaveDocumentAs()
            Call Debug.WriteLine("CustomDesignerCommands.SaveDocumentAs")
            MyBase.SaveDocumentAs()
        End Sub
    End Class
End Namespace
