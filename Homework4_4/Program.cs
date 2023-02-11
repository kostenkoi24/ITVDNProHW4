using System;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Homework4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
           
            string path = "CheckFile.xml";

            FileStream stream = new FileStream(path, FileMode.Open);

            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Document));

            Document document = xmlSerializer.Deserialize(stream) as Document;



            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Поточна локаль: {0}.", currentCulture);
            var american = new CultureInfo("en-US"); // почему то все равно выводит ₽, и в примере 007_FormattedStrings.csproj так же
            var ukraine = new CultureInfo("uk-UA"); //работает нормально = ₴


            Console.WriteLine(document.DocHeader.Data);

            foreach (var goods in document.Table)
            {
                double Amount = goods.Amount;
                Console.WriteLine($"Goods: {goods.Goods} \n\tAmount in Local: {Amount.ToString("C", ukraine)} \n\tAmount in US: {Amount.ToString("C", american)} \n\tQty: {goods.Qty}");
            }

            Console.ReadKey();
        }
    }
}
