using System.Drawing;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace RepOverrideRtfFormatting {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        private RichEditDocumentServer richEditDocumentServer;
        public bool OverrideRtfFormatting { get; set; }

        public XtraReport1() {
            InitializeComponent();
        }

       private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if (OverrideRtfFormatting) {
                if (richEditDocumentServer == null)
                    richEditDocumentServer = new RichEditDocumentServer();
                xrRichText1.DataBindings.Clear();
            }
            else
                xrRichText1.DataBindings.Add("Rtf", null, "Cars.RtfContent");
        }

        private void xrRichText1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
           if (!OverrideRtfFormatting)
               return;
            
            richEditDocumentServer.RtfText = GetCurrentColumnValue("RtfContent").ToString();
            ApplyRTFModification(richEditDocumentServer);
            xrRichText1.Rtf = richEditDocumentServer.RtfText;
        }

        private void ApplyRTFModification(RichEditDocumentServer server) {
            // Apply default formatting
            server.Document.DefaultCharacterProperties.FontName = "Arial";
            server.Document.DefaultCharacterProperties.FontSize = 9;
            server.Document.DefaultCharacterProperties.ForeColor = Color.FromArgb(120, 120, 120);
            server.Document.DefaultParagraphProperties.Alignment = ParagraphAlignment.Center;

            // Remove whitespaces from the end of RTF content
            DocumentRange[] dots = server.Document.FindAll(".", SearchOptions.None);
            DocumentPosition lastDot = dots[dots.Length - 1].End;
            server.Document.Delete(server.Document.CreateRange(lastDot, server.Document.Range.End.ToInt() - lastDot.ToInt()));
            
            // Append formatted word
            DocumentRange range = server.Document.InsertText(server.Document.Range.End, " [Approved]");
            CharacterProperties cp = server.Document.BeginUpdateCharacters(range);
            cp.FontName = "Courier New";
            cp.FontSize = 10;
            cp.ForeColor = Color.Red;
            cp.Underline = UnderlineType.Single;
            cp.UnderlineColor = Color.Red;
            server.Document.EndUpdateCharacters(cp);
        }
    }
}
