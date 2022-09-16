Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace RepOverrideRtfFormatting

    Public Partial Class XtraReport1

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private GroupHeader0 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrRichText1 As DevExpress.XtraReports.UI.XRRichText

        Public dsCars1 As RepOverrideRtfFormatting.dsCars

        Private carsTableAdapter1 As RepOverrideRtfFormatting.dsCarsTableAdapters.CarsTableAdapter

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepOverrideRtfFormatting.XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
            Me.GroupHeader0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.dsCars1 = New RepOverrideRtfFormatting.dsCars()
            Me.carsTableAdapter1 = New RepOverrideRtfFormatting.dsCarsTableAdapters.CarsTableAdapter()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            CType((Me.xrRichText1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsCars1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrRichText1})
            Me.Detail.HeightF = 17F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrRichText1
            ' 
            Me.xrRichText1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrRichText1.CanShrink = True
            Me.xrRichText1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "Cars.RtfContent")})
            Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 1F)
            Me.xrRichText1.Name = "xrRichText1"
            Me.xrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrRichText1.SizeF = New System.Drawing.SizeF(688F, 16F)
            Me.xrRichText1.StylePriority.UseBorders = False
            Me.xrRichText1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            AddHandler Me.xrRichText1.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrRichText1_BeforePrint)
            ' 
            ' GroupHeader0
            ' 
            Me.GroupHeader0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.GroupHeader0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader0.HeightF = 48F
            Me.GroupHeader0.Name = "GroupHeader0"
            Me.GroupHeader0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cars.Model")})
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 14.25F, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline)), System.Drawing.FontStyle))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(141F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(418F, 28F)
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox4})
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = CType((resources.GetObject("xrPictureBox4.Image")), System.Drawing.Image)
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(276F, 8F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(148.9583F, 41.66667F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' dsCars1
            ' 
            Me.dsCars1.DataSetName = "dsCars"
            Me.dsCars1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsCars1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' carsTableAdapter1
            ' 
            Me.carsTableAdapter1.ClearBeforeFill = True
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 75F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeader0, Me.BottomMargin, Me.topMarginBand1})
            Me.DataAdapter = Me.carsTableAdapter1
            Me.DataMember = "Cars"
            Me.DataSource = Me.dsCars1
            Me.Margins = New System.Drawing.Printing.Margins(75, 75, 75, 75)
            Me.Version = "11.1"
            AddHandler Me.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.XtraReport1_BeforePrint)
            CType((Me.xrRichText1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsCars1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    End Class
End Namespace
