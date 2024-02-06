using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serialize
{
    public class Cereal
    {
        public string Name { get; set; }
        public string Slogan { get; set; }
        public Boolean Approved { get; set; }
        public int Calories { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cereal luckyCharms = new Cereal();
            luckyCharms.Name = "Lucky Charms";
            luckyCharms.Slogan = "They're magically delicious.";
            luckyCharms.Approved = true;
            luckyCharms.Calories = 140;
            luckyCharms.Price = 2.99m;
            //luckyCharms.Image = ;

            Cereal cookieCrisp = new Cereal();
            cookieCrisp.Name = "Cookie Crisp";
            cookieCrisp.Slogan = "Cooookie Crisp. Next time, it's mine!";
            cookieCrisp.Approved = false;
            cookieCrisp.Calories = 140;
            cookieCrisp.Price = 6.48m;
            //cookieCrisp.Image = ;

            Cereal trix = new Cereal();
            trix.Name = "Trix";
            trix.Slogan = "Silly rabbit! Trix are for kids!";
            trix.Approved = false;
            trix.Calories = 160;
            trix.Price = 4.48m;
            //trix.Image = ;

            string jsonString = JsonSerializer.Serialize(luckyCharms);
            Console.WriteLine(jsonString);

            Cereal unluckyCharms = new Cereal();
            unluckyCharms = JsonSerializer.Deserialize<Cereal>(jsonString);

            Console.ReadKey();
        }
    }
}
