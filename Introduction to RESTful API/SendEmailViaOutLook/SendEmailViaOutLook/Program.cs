using System;
using Outlook = Microsoft.Office.Interop.Outlook;

class Program
{
    static void Main()
    {
        try
        {
            // تشغيل Outlook
            Outlook.Application outlookApp =
                new Outlook.Application();

            // إنشاء رسالة جديدة
            Outlook.MailItem mail =
                (Outlook.MailItem)
                outlookApp.CreateItem(
                    Outlook.OlItemType.olMailItem);

            // بيانات الرسالة
            mail.To = "saddamalzekri33@gmail.com";

            mail.Subject = "Test Message";

            mail.Body =
                "Hello From Outlook API";

            // إرسال الرسالة
            mail.Send();

            Console.WriteLine(
                "Email Sent Successfully.");
        }

        catch (Exception ex)
        {
            Console.WriteLine(
                "Error: " + ex.Message);
        }
    }
}