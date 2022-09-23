using System;
namespace LevionJewelry.Models
{
    //Inventory Class
    public static class Inventory
    {   //create a list from jewlery class and constructs jewelry name, rating etc
        public static List<Jewelry> ToList()
        {
            //return list 
            return new List<Jewelry>
            {
             
                new Jewelry(name: "14k Strawberry Gold® Ring", rating:"5.0 (30)", image:"https://media.levian.com/medium/invtryhires/TRPN%2061.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14k Strawberry Gold® Ring", rating:"5.0 (28)", image:"https://media.levian.com/medium/invtryhires/WJBA%2073.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
               
                new Jewelry(name: "14k Strawberry Gold® Ring", rating:"4.8 (22)", image:"https://media.levian.com/medium/invtryhires/ZUOV%2087.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14k Strawberry Gold® Ring", rating:"5.0 (20)", image:"https://media.levian.com/medium/invtryhires/WATL%2021.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14k Strawberry Gold® Blueberry Tanzanite 2Cts Ring", rating:"5.0 (20)", image:"https://media.levian.com/medium/invtryhires/YRHS%2042.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
          
                new Jewelry(name: "P95", rating:"5.0 (15)", image:"https://media.levian.com/medium/invtryhires/TRPN%2029.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
             
                new Jewelry(name: "14k Strawberry Gold Ring", rating:"5.0 (12)", image:"https://media.levian.com/medium/invtryhires/YRPN%2061.jpg", price: "3000", modelnumber: "123",jewelrytype:"Ring"),
               
                new Jewelry(name: "14k Vanilla Gold Passion Ruby 4 1/5 Cts Ring", rating:"5.0 (13)", image:"https://media.levian.com/medium/invtryhires/TRAF%2070.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Strawberry Gold® Costa Smeralda Emeralds™ 1/2 cts. Ring", rating:"4.9 (13)", image:"https://media.levian.com/medium/invtryhires/TRPN%2068.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
               
                new Jewelry(name: "14K Vanilla Gold® Sea Blue Aquamarine® 5/8 cts., Blueberry Tanzanite® 5/8 cts. Ring", rating:"4.9 (15)", image:"https://media.levian.com/medium/invtryhires/WJIP%2070.jpg", price: "3000", modelnumber: "123",jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Strawberry Gold® Pomegranate Garnet™ 3/4 cts. Pendant", rating:"5.0 (13)", image:"https://media.levian.com/medium/invtryhires/WJKN%2013.jpg", price: "3000", modelnumber: "123", jewelrytype:"Necklace"),

                new Jewelry(name: "14k Strawberry Gold® Ring", rating:"4.8 (17)", image:"https://media.levian.com/medium/invtryhires/TRAH%202.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14k Strawberry Gold® Ring", rating:"4.7 (13)", image:"https://media.levian.com/medium/invtryhires/TQCO%201.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14k Two Tone Gold® Ring", rating:"5.0 (9)", image:"https://media.levian.com/medium/invtryhires/WJKY%201.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Strawberry Gold® Peacock Aquaprase™ 7 1/5 cts., Vanilla Topaz™ 1/3 cts. Ring", rating:"5.0 (12)", image:"https://media.levian.com/medium/invtryhires/SVHM%2057.jpg", price: "3000", modelnumber: "123" ,jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Vanilla Gold® Denim Ombré® 2 cts. Bolo Bracelet", rating:"5.0 (7)", image:"https://media.levian.com/medium/invtryhires/DEKI%20568.jpg", price: "3000", modelnumber: "123", jewelrytype:"Bracelet"),
             
                new Jewelry(name: "14K Vanilla Gold® Pendant", rating:"5.0 (12)", image:"https://media.levian.com/medium/invtryhires/TPIK%202.jpg", price: "3000", modelnumber: "123", jewelrytype:"Necklace"),
                
                new Jewelry(name: "14K Two Tone Gold® Ring", rating:"5.0 (9)", image:"https://media.levian.com/medium/invtryhires/BACW%2012.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Strawberry Gold® Deep Sea Blue Topaz™ 1 cts. Ring", rating:"5.0 (10)", image:"https://media.levian.com/medium/invtryhires/TRJQ%2059.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring" ),
               
                new Jewelry(name: "14k Strawberry Gold® Ring", rating:"5.0 (9)", image:"https://media.levian.com/medium/invtryhires/TRAG%2013.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Strawberry Gold® Passion Ruby™ 1/4 cts. Pendant", rating:"5.0 (7)", image:"https://media.levian.com/medium/invtryhires/WJPZ%2011.jpg", price: "3000", modelnumber: "123", jewelrytype:"Necklace"),
                
                new Jewelry(name: "14K Strawberry Gold® Grape Amethyst™ 7/8 cts. Ring", rating:"5.0 (9)", image:"https://media.levian.com/medium/invtryhires/TRRP%2075.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
               
                new Jewelry(name: "14K Vanilla Gold® Blueberry Sapphire™ 1/2 cts. Ring", rating:"4.8 (10)", image:"https://media.levian.com/medium/invtryhires/TRRR%202D.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
              
                new Jewelry(name: "14K Strawberry Gold® Pomegranate Garnet™ 7 5/8 cts., Forest Green Tsavorite™ 3/8 cts., Vanilla Topaz™ 3/8 cts., Grape Amethyst™ 1/10 cts. Ring", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/SUUU%201.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Strawberry Gold® Strawberry Ombré® 3/8 cts., White Sapphire 1/6 cts. Ring", rating:"5.0 (7)", image:"https://media.levian.com/medium/invtryhires/YRAH%20143.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
              
                new Jewelry(name: "14K Strawberry Gold® Strawberry Ombré® 3/8 cts., White Sapphire 1/6 cts. Ring", rating:"5.0 (7)", image:"https://media.levian.com/medium/invtryhires/YRAH%20143.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),
                
                new Jewelry(name: "14K Strawberry Gold® Bolo Bracelet", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/DEKI%201139.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Grape Amethyst™ 2 3/4 cts. Ring", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/TRYR%201AMRG.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Vanilla Gold® Sea Blue Aquamarine® 3/4 cts. Ring", rating:"5.0 (9)", image:"https://media.levian.com/medium/invtryhires/WJKQ%2058.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Honey Gold™ Neopolitan Opal™ 1 1/2 cts., Spessartite 1/3 cts., Pomegranate Garnet™ 1/6 cts., Bubble Gum Pink Sapphire™ 1/6 cts., Forest Green Tsavorite™ 1/6 cts., Blueberry Sapphire™ 1/8 cts., Dark Amethyst 1/8 cts. Earrings", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/TRPT%206E.jpg", price: "3000", modelnumber: "123", jewelrytype:"Earrings"),

                new Jewelry(name: "14K Strawberry Gold® Neopolitan Opal™ 7/8 cts. Pendant", rating:"4.9 (10)", image:"https://media.levian.com/medium/invtryhires/TRFS%202.jpg", price: "3000", modelnumber: "123", jewelrytype:"Necklace"),

                new Jewelry(name: "14K Strawberry Gold® Ring", rating:"4.8 (6)", image:"https://media.levian.com/medium/invtryhires/TRPN%2057.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "P95 Vanilla Gold® Cornflower Sapphire™ 1 1/5 cts. Ring", rating:"5.0 (4)", image:"https://media.levian.com/medium/invtryhires/YQQW%2032.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Peacock Aquaprase™ 8 3/4 cts. Ring", rating:"4.3 (6)", image:"https://media.levian.com/medium/invtryhires/BVIR%20126.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "P18 Honey Gold™ Ring", rating:"5.0 (5)", image:"https://media.levian.com/medium/invtryhires/TSBS%202.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14k Vanilla Gold Ring", rating:"5.0 (4)", image:"https://media.levian.com/medium/invtryhires/PZHD%201.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Raspberry Rhodolite® 1 3/8 cts. Ring", rating:"5.0 (4)", image:"https://media.levian.com/medium/invtryhires/SVCL%2026.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Raspberry Rhodolite® 2 cts. Ring", rating:"5.0 (5)", image:"https://media.levian.com/medium/invtryhires/BVMQ%207RHRG.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Honey Gold™ Pendant", rating:"5.0 (4)", image:"https://media.levian.com/medium/invtryhires/TPSM%203.jpg", price: "3000", modelnumber: "123", jewelrytype:"Necklace"),

                new Jewelry(name: "14K Strawberry Gold® Chocolate Quartz® 3/4 cts. Ring", rating:"5.0 (4)", image:"https://media.levian.com/medium/invtryhires/TQPB%2043S7.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Neopolitan Opal™ 1 5/8 cts., Orange Sapphire 1/2 cts., Blueberry Sapphire™ 1/3 cts., Bubble Gum Pink Sapphire™ 1/5 cts., Green Sapphire 1/3 cts., Yellow Sapphire 1/6 cts. Ring", rating:"5.0 (4)", image:"https://media.levian.com/medium/invtryhires/SVFQ%2078.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Ring", rating:"5.0 (4)", image:"https://media.levian.com/medium/invtryhires/TRBI%20527.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Deep Sea Blue Topaz™ 2 cts. Ring", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/TRFS%2023.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Pendant", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/TRCZ%2010.jpg", price: "3000", modelnumber: "123", jewelrytype:"Necklace"),

                new Jewelry(name: "14K Strawberry Gold® Peach Morganite™ 1 1/3 cts. Ring", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/TRFS%207.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Grape Amethyst™ 1 1/8 cts., Blueberry Sapphire™ 1 cts. Ring", rating:"5.0 (7)", image:"https://media.levian.com/medium/invtryhires/TRHA%2017.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Passion Ruby™ 1 1/2 cts. Ring", rating:"5.0 (9)", image:"https://media.levian.com/medium/invtryhires/TRGX%207.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Honey Gold™ Costa Smeralda Emeralds™ 7/8 cts. Ring", rating:"5.0 (6)", image:"https://media.levian.com/medium/invtryhires/TRIT%2010.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Honey Gold™ Pomegranate Garnet™ 1 cts. Ring", rating:"4.7 (9)", image:"https://media.levian.com/medium/invtryhires/TRTB%202A.jpg", price: "3000", modelnumber: "123", jewelrytype:"Ring"),

                new Jewelry(name: "14K Strawberry Gold® Blueberry Sapphire™ 3/4 cts., Grape Amethyst™ 7/8 cts. Pendant", rating:"5.0 (5)", image:"https://media.levian.com/medium/invtryhires/TRSP%2055.jpg", price: "3000", modelnumber: "123", jewelrytype:"Necklace")
            };
        }
    }
}

