using System;
using System.IO;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

class Program
{
    public class DataJson
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public List<DataJson> Sub { get; set; }
    }

    public static void Main()
    {
        string filePath = "C:\\Users\\User\\Desktop\\SummaryFunc\\SummaryFunc\\file\\data.json";

        string jsonString = File.ReadAllText(filePath);

        var data = JsonConvert.DeserializeObject<List<DataJson>>(jsonString);

        List<int> amounts = new List<int>();

        GetAmounts(data, amounts);

        int result = 0;

        foreach (var amount in amounts)
        {
            result += amount;
        }

        Console.WriteLine(result);
    }

    public static void GetAmounts(List<DataJson> data, List<int> amounts)
    {
        foreach (var dt in data)
        {
            amounts.Add(dt.Amount); 
                        
            if (dt.Sub != null && dt.Sub.Count > 0)
            {
                GetAmounts(dt.Sub, amounts);
            }
        }
    }
}
