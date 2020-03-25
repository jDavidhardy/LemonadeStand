using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;

namespace MyLemonadeStand
{
    class Weather
    {

        //member variables (HAS A)
        public string condition;
        public int temperature;
        Random random = new Random();
        private List<string> weatherConditons;

      /*  public Weather(string condition, int temperature, List<string> weatherConditons)
        {

        }*/

        //constructor
        public Weather(string condition, int temperature, List<string> weatherConditions)
        {  
            var random = new Random();
            weatherConditons = new List<string> { "overcast", "rain", "sunny" };
            int index = random.Next(weatherConditons.Count);
            Console.WriteLine(weatherConditons[index]);
            Console.ReadLine();

            GenerateRandomCondition();
            GenerateRandomTemerature();
        }

        public string GenerateRandomCondition()
        {
            condition = weatherConditons[random.Next(weatherConditons.Count)];
            return condition;
        }

        private void GenerateRandomTemerature()
        {
            if (condition == "sunny")
            {
                temperature = random.Next(80, 95);
            }
            else if (condition == "rain")
            {
                temperature = random.Next(55, 69);
            }
            else if (condition == "overcast")
            {
                temperature = random.Next(70, 79);
                
            }
            Console.ReadLine();
        }
    }
}
