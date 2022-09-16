Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace ReportingXRRichTextFormatSample
	Partial Public Class Form1
		Inherits Form

		Private report As New XtraReport1()

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			report.OverrideRtfFormatting = checkBox1.Checked
			report.CreateDocument()
			report.ShowPreviewDialog()
		End Sub
	End Class
End Namespace