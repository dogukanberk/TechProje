using JsonParse;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace KaizenTech
{
    public class Soru3
    {
        ItemResponse itemResponse = new ItemResponse();

        private void loadData()
        {
            List<ItemResponse> items;
            try
            {
                using (StreamReader r = new StreamReader("C:\\Users\\doguk\\source\\repos\\KaizenTech\\JsonParse\\response.json"))
                {
                    string json = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<ItemResponse>>(json);
                }
                if (items != null && items.Any())
                {
                    writeData(items);
                }
                else
                {
                    Console.WriteLine("Dosya İçeriği Hatalı");
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex);
                throw;
            }

        }

        private void writeData(List<ItemResponse> listOfItems)
        {
            var firstDescription = listOfItems.First();

            var stringList = firstDescription.Description.Split("\n");
            for (int i = 0; i < stringList.Count(); i++)
            {
                Console.WriteLine(stringList[i]);
            }

        }

        static void Main(string[] args)
        {
            Soru3 p = new Soru3();
            p.loadData();
            
        }

    }

}