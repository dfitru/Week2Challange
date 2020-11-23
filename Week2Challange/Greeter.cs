using System;

namespace Week2Challange
{
    public class Greeter

    {
        public string Greeting(string name)
        {
            return "Hello "+name;
        }
        public string GoodBye(string name)
        {
            return "Good Bye " + name;
        }

        public string BaseTimeGreeting(string baseTimeGreeting)
        {
            int timeGreeting = Convert.ToInt32(baseTimeGreeting);
            if (timeGreeting>=6&& timeGreeting<12)
            {
                return "Good Mornig.";
            }else if(timeGreeting<18 && timeGreeting>=12)
            {
                return "Good Afternoon.";
            }
            else
            {
                return "Good Evening.";
            }
        }
        public static void Main(string[] args)
        {
            string hiName;
            string byName;
            
            Greeter greet = new Greeter();
            hiName = greet.Greeting("David");
            byName = greet.GoodBye("Dawit");
            
            Console.WriteLine(hiName);
            Console.ReadLine();

            Console.WriteLine(byName);
            Console.ReadLine();

            Console.WriteLine("Please Enter Time between 0 and 23: ");
            int giveTime=Convert.ToInt32(Console.ReadLine());
            string inputTime=giveTime.ToString();
            //Console.WriteLine("Enter Time: between 0 and 23 ");
            string outPut = greet.BaseTimeGreeting(inputTime);
            Console.WriteLine(outPut);
            
            
           
            
        }
    }
}
