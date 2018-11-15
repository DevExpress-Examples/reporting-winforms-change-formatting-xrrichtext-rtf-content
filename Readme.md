<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to override RTF formatting in XRRichText


<p><strong>Problem:</strong><br />
I am creating a data-aware report. The source data table has a column containing RTF text. I need to override several RTF settings before displaying it in <a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRRichTexttopic"><u>XRRichText</u></a>. I have tried many properties including the following but it does not work for me:</p><p>XRRichText.ForeColor<br />
XRRichText.Font<br />
XRRichText.TextAlignment</p><p><strong>Solution:</strong><br />
The approach of modifying the RTF setting directly via the XRRichText properties will not help you achieve the desired result. The RTF format supports complex formatting for different content parts and it is impossible to manage corresponding format settings in this manner. We have already discussed this topic in detail in the following threads:</p><p><a href="https://www.devexpress.com/Support/Center/p/B38722">XRRichText - Font settings aren't applied correctly</a><br />
<a href="https://www.devexpress.com/Support/Center/p/Q22554">XRRichText text alignment</a><br />
<a href="https://www.devexpress.com/Support/Center/p/Q290811">Bold Text in XrRichText</a><br />
<a href="https://www.devexpress.com/Support/Center/p/Q306727">XRRichText Default Font</a><br />
<a href="https://www.devexpress.com/Support/Center/p/Q217864">rtf font override</a></p><p>The correct solution is to utilize special RTF-aware API. Our XtraRichEdit Suite provides you with this API. In v2011 vol 1 we have implemented the non-visual <a href="http://search.devexpress.com/?q=RichEditDocumentServer&p=T0|P0|0&d=2943"><u>RichEditDocumentServer</u></a> component (in previous versions use the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraRichEditRichEditControltopic"><u>RichEditControl Class</u></a> instead). This example illustrates how this component can be used to override RTF formatting and even append arbitrary content to the source RTF (see the <strong>XtraReport1.ApplyRTFModification()</strong> method).</p><p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E3416">How to concatenate values of several RTF fields to display the resulting RTF content in a single XRRichText control</a></p>

<br/>


