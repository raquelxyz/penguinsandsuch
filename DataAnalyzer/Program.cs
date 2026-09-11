using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
class Program
{
    static void Main()
    {
        Console.WriteLine("Testing!");
        using (var reader = new StreamReader("../data/penguins_size.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<CsvHelperMap>();
            List<CsvHelperObject> records = csv.GetRecords<CsvHelperObject>().ToList();
            // Start: Checking the validity of the records
            // foreach (var item in records)
            // {
            //     Console.WriteLine(item.Length);
            // }
            // END
            
            //Total penguins!
            int totalPenguins = records.Count();
            //END

            //Top five penguins by LENGTH!!
            IEnumerable<CsvHelperObject> topFiveLongPenguins = records.OrderByDescending(record => record.Length).Take(5);
            Console.WriteLine($"Here are the top five penguins sorted by length!:");
            foreach (var penguin in topFiveLongPenguins)
            {
                Console.Write($" {penguin.Length}");
            }
            //END

            foreach (CsvHelperObject penguin in records.OrderByDescending(penguin => CsvHelperObject.LengthToFlipperLength()))
            {
                
            }
            
        }
        
    }
}
