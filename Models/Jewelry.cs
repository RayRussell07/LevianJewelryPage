using System;
namespace LevionJewelry.Models
{
    //Jewelry Class
    public class Jewelry
    {
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string ModelNumber { get; set; }
        public string JewelryType { get; set; }

        //Jewelry Constructor with name, rating, image, price, model  number, jewlelry type parameters
        public Jewelry(string name = "Not Found", string rating = "5.0 ()", string image = "/images/blank.png", string price = "n/a", string modelnumber = "n/a", string jewelrytype ="n/a")
        {
            Name = name;
            Rating = rating;
            Image = image;
            Price = price;
            ModelNumber = modelnumber;
            JewelryType = jewelrytype;
        }
    }
}

