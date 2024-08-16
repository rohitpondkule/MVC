using System.Text;
using UglyToad.PdfPig;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;

namespace itvidpradotnetcoreadvanced.Services.CSharpServices
{
    public class FileReaderService : IFileReaderService
    {
        public string ReadContent(string fileName)
        {
            StringBuilder outputString = new StringBuilder();
            using (var pdf = PdfDocument.Open(fileName))
            {
                foreach (var page in pdf.GetPages())
                {
                    // Either extract based on order in the underlying document with newlines and spaces.
                    var text = ContentOrderTextExtractor.GetText(page);

                    //// Or based on grouping letters into words.
                    //var otherText = string.Join(" ", page.GetWords());

                    //// Or the raw text of the page's content stream.
                    //var rawText = page.Text;
                    outputString.Append(text);
                    Console.WriteLine(text);
                }
            }
            return outputString.ToString();
        }
    }
}