Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RepOverrideRtfFormatting
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private richEditDocumentServer As RichEditDocumentServer
		Private privateOverrideRtfFormatting As Boolean
		Public Property OverrideRtfFormatting() As Boolean
			Get
				Return privateOverrideRtfFormatting
			End Get
			Set(ByVal value As Boolean)
				privateOverrideRtfFormatting = value
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

	   Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
			If OverrideRtfFormatting Then
				If richEditDocumentServer Is Nothing Then
					richEditDocumentServer = New RichEditDocumentServer()
				End If
				xrRichText1.DataBindings.Clear()
			Else
				xrRichText1.DataBindings.Add("Rtf", Nothing, "Cars.RtfContent")
			End If
	   End Sub

		Private Sub xrRichText1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrRichText1.BeforePrint
		   If (Not OverrideRtfFormatting) Then
			   Return
		   End If

			richEditDocumentServer.RtfText = GetCurrentColumnValue("RtfContent").ToString()
			ApplyRTFModification(richEditDocumentServer)
			xrRichText1.Rtf = richEditDocumentServer.RtfText
		End Sub

		Private Sub ApplyRTFModification(ByVal server As RichEditDocumentServer)
			' Apply default formatting
			server.Document.DefaultCharacterProperties.FontName = "Arial"
			server.Document.DefaultCharacterProperties.FontSize = 9
			server.Document.DefaultCharacterProperties.ForeColor = Color.FromArgb(120, 120, 120)
			server.Document.DefaultParagraphProperties.Alignment = ParagraphAlignment.Center

			' Remove whitespaces from the end of RTF content
			Dim dots() As DocumentRange = server.Document.FindAll(".", SearchOptions.None)
			Dim lastDot As DocumentPosition = dots(dots.Length - 1).End
			server.Document.Delete(server.Document.CreateRange(lastDot, server.Document.Range.End.ToInt() - lastDot.ToInt()))

			' Append formatted word
			Dim range As DocumentRange = server.Document.InsertText(server.Document.Range.End, " [Approved]")
			Dim cp As CharacterProperties = server.Document.BeginUpdateCharacters(range)
			cp.FontName = "Courier New"
			cp.FontSize = 10
			cp.ForeColor = Color.Red
			cp.Underline = UnderlineType.Single
			cp.UnderlineColor = Color.Red
			server.Document.EndUpdateCharacters(cp)
		End Sub
	End Class
End Namespace
