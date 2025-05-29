using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    public class Ad
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public Category Category { get; set; }
        public DateTime CreateAt { get; set; }
        public string Description { get; set; }
        public int Floors { get; set; }
        public bool FreeOfCharge { get; set; }
        public string ImageUrl { get; set; }
        public string LatLong { get; set; }
        public int Rooms { get; set; }
        public Seller Seller { get; set; }

        public Ad(int id, int area, Category category, DateTime createAt, string description, int floors, bool freeOfCharge, string imageUrl, string latLong, int rooms, Seller seller)
        {
            Id = id;
            Area = area;
            Category = category;
            CreateAt = createAt;
            Description = description;
            Floors = floors;
            FreeOfCharge = freeOfCharge;
            ImageUrl = imageUrl;
            LatLong = latLong;
            Rooms = rooms;
            Seller = seller;
        }

        //7.feladat
        public double DistanceTo(string mesevarCoords)
        {
            string[] kozeli = LatLong.Split(',');
            string[] mesevar = mesevarCoords.Split(',');

            return  Math.Sqrt(
                    Math.Pow(double.Parse(kozeli[0].Replace('.', ',')) - double.Parse(mesevar[0].Replace('.', ',')), 2) + 
                    Math.Pow(double.Parse(kozeli[1].Replace('.', ',')) - double.Parse(mesevar[1].Replace('.', ',')), 2));
        }

        public static List<Ad> LoadFromCSV(string path)
        {
            List<Ad> ads = new List<Ad>();

            string[] temp = File.ReadAllLines(path);

            foreach (var t in temp.Skip(1))
            {
                string[] v = t.Split(';');

                int Id = int.Parse(v[0]);
                int Rooms = int.Parse(v[1]);
                string LatLong = v[2];
                int Floors = int.Parse(v[3]);
                int Area = int.Parse(v[4]);
                string Description = v[5];
                bool FreeOfCharge = int.Parse(v[6]) == 1 ? true : false;
                string ImageUrl = v[7];
                DateTime CreateAt = DateTime.Parse(v[8]);
                Seller Seller = new(int.Parse(v[9]), v[10], v[11]);
                Category Category = new(int.Parse(v[12]), v[13]);

                Ad ad = new Ad(Id, Area, Category, CreateAt, Description, Floors, FreeOfCharge, ImageUrl, LatLong, Rooms, Seller);
                ads.Add(ad);
            }
            return ads;
        }

    }
}
