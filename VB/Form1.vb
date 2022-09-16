Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace RepOverrideRtfFormatting

    Public Partial Class Form1
        Inherits Form

        Private report As XtraReport1 = New XtraReport1()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            report.OverrideRtfFormatting = checkBox1.Checked
            report.CreateDocument()
            report.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
