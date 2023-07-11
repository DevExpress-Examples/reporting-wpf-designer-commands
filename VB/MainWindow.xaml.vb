Imports System.Diagnostics
Imports System.Windows
Imports DevExpress.Xpf.Reports.UserDesigner

Namespace T461334
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			designer.Commands = New CustomDesignerCommands()
			AddHandler Me.Loaded, AddressOf MainWindow_Loaded
		End Sub

		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			designer.OpenDocument(New SampleReport())
		End Sub
	End Class

	Public Class CustomDesignerCommands
		Inherits ReportDesignerCommands

		Protected Overrides Sub SaveDocumentAs()
			Debug.WriteLine("CustomDesignerCommands.SaveDocumentAs")
			MyBase.SaveDocumentAs()
		End Sub
	End Class
End Namespace
