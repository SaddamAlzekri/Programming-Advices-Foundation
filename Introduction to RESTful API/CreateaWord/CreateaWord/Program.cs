using System;
using Word = Microsoft.Office.Interop.Word;

class Program
{
    static void Main()
    {
        try
        {
            // تشغيل Microsoft Word
            Word.Application wordApp =
                new Word.Application();

            // إظهار برنامج Word
            wordApp.Visible = true;

            // إنشاء مستند جديد
            Word.Document document =
                wordApp.Documents.Add();

            // كتابة نص داخل المستند
            Word.Paragraph paragraph =
                document.Content.Paragraphs.Add();

            paragraph.Range.Text =
                "Hello From C# Win32 COM API";

            paragraph.Range.InsertParagraphAfter();

            // حفظ الملف
            string path =
                @"C:\TestDocument.docx";

            document.SaveAs2(path);

            Console.WriteLine(
                "Word document created successfully.");

            Console.WriteLine(
                "Saved To: " + path);
        }

        catch (Exception ex)
        {
            Console.WriteLine(
                "Error: " + ex.Message);
        }

        Console.ReadKey();
    }
}
