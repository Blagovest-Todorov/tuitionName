using System;

namespace _3.task
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine(); 
            int numHourSpent = int.Parse(Console.ReadLine());
            int numPerson = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine(); 
            double sumPrice = 0;
            double sumPriceOneMan = 0;

            if (month == "march" || month == "april" || month == "may")
            {               
                if (timeOfDay  == "day")
                {
                    sumPriceOneMan += 10.50; 
                    sumPrice += 10.50 * numHourSpent * numPerson;
                    if (numPerson >= 4 )
                    {
                        sumPrice *= 0.90; 
                        sumPriceOneMan  *= 0.90;
                        if (numHourSpent >= 5)
                        {
                            sumPrice *= 0.50;
                            sumPriceOneMan *= 0.50;
                        }
                    }                 
                }
                else if (timeOfDay == "night")
                {
                    sumPrice = 8.40 * numHourSpent * numPerson;
                    if (numPerson >= 4)
                    {
                        sumPrice *= 0.90;
                        if (numPerson >= 4)
                        {
                            sumPrice *= 0.50;                           
                        }
                    }                    
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (timeOfDay == "day")
                {
                    sumPriceOneMan += 12.60; 
                    sumPrice += 12.60 * numHourSpent * numPerson; 
                    if (numPerson >= 4)
                    {
                        sumPrice *= 0.90;  
                        sumPriceOneMan *= 0.90;
                        if (numHourSpent >= 5)
                        {
                            sumPrice *= 0.50;
                            sumPriceOneMan *= 0.50;
                        }
                    }

                }
                else if (timeOfDay == "night")
                {
                    sumPriceOneMan += 10.20; 
                    sumPrice += 10.20 * numHourSpent * numPerson; 
                    if (numPerson >= 4)
                    {
                        sumPrice *= 0.90; 
                        sumPriceOneMan *= 0.90;
                        if (numHourSpent >= 5)
                        {
                            sumPrice *= 0.50;
                            sumPriceOneMan *= 0.50;
                        }
                    }
                }
            }
            Console.WriteLine($"Price per person for one hour: {sumPriceOneMan:F2}");
            Console.WriteLine($"Total cost of the visit: {sumPrice:F2}");
        }
    }
}
