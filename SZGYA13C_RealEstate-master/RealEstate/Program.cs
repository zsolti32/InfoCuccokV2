namespace RealEstate
{
    internal class Program
    {
        List<Ad> ads = new List<Ad>();
        static void Main(string[] args)
        {
            List<Ad> ads = Ad.LoadFromCSV(@"..\..\..\src\realestates.csv");

            //6. feladat
            var f6 = ads.Where(a => a.Floors == 0).Average(a => a.Area);
            Console.WriteLine($"1. Földszinti ingatlanok átlagos alapterülete: {Math.Round(f6, 2)} m2");

            //7. feladat
            string MesevarCoords = "47.4164220114023,19.066342425796986";
            var f7 = ads.MinBy(a => a.DistanceTo(MesevarCoords));

            Console.WriteLine("2. Mesevár óvodához légvonalban legközelebbi tehermentes ingatlan adatai:");
            Console.WriteLine($"\tEladó neve:\t {f7.Seller.Name}");
            Console.WriteLine($"\tEladó telefonja: {f7.Seller.Phone}");
            Console.WriteLine($"\tAlapterület:\t {f7.Area}");
            Console.WriteLine($"\tSzobák száma:\t {f7.Rooms}");


        }
    }
}
