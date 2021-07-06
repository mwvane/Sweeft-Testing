using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SweetTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1:
            //1.Console.WriteLine(IsPalindrome((string)Console.ReadLine()));

            // Task 2:
            //Console.Write(MinSplit(Convert.ToInt32(Console.ReadLine())));

            // Task 3:
            //int[] array = new int[] {1,2,5,4,3};
            //Console.WriteLine(NotContains(array));

            // Task 4:
            /*
            Console.WriteLine(IsProperly("383838()"));
            Console.WriteLine(IsProperly("3838)("));*/

            // Task 5:
            //Console.WriteLine(CountVariants(4));

            //  Task 6:
            //DeleteFromData(3);

            // Task 8:
            //Console.WriteLine(Exchange("EUR", "USD"));

            Console.ReadKey();
        }

        /* 1. დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი  და აბრუნებს პალინდრომია თუ არა. 
         * (პალინდრომი არის ტექსტი რომელიც ერთნაირად იკითხება ორივე მხრიდან). */
        public static bool IsPalindrome(String text)
        {
            if (text.Length > 0)
            {
                string textOne = "";
                string textTwo = "";
                if (text.Length % 2 == 0)
                {
                    textOne = text.Substring(0, text.Length / 2);
                    textTwo = ReverseString((text.Substring(text.Length / 2, text.Length / 2)));
                }
                else
                {
                    textOne = text.Substring(0, (text.Length - 1) / 2);
                    textTwo = ReverseString((text.Substring((text.Length + 1 )/ 2, (text.Length -1) / 2)));
                }
                return IsEqual(textOne, textTwo);
            }
            return false;
        }

        public static string ReverseString(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static bool IsEqual(string textOne , string textTwo)
        {
            if (textOne == textTwo)
            {
                return true;
            }
            return false;
        }

        /* 2. გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც გადაეცემა თანხა 
         * (თეთრებში) და აბრუნებს მონეტების მინიმალურ რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.*/

        public static int MinSplit(int amount)
        {
            int[] monets = new int[] {50,20,10,5,1};
            int counter = 0;
            for (int i = 0; i < monets.Length; i++)
            {
                if (monets[i] <= amount)
                {
                    counter += amount / monets[i];
                    amount = amount % monets[i];
                }
            }
            return counter;
        }

        /*  3. მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. დაწერეთ ფუნქცია რომელსაც გადაეცემა ეს მასივი და 
         *  აბრუნებს მინიმალურ მთელ რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.*/

        public static int NotContains(int[] array)
        {
            for (int i = 1; i < array.Max()+2; i++)
            {
                if (array.Contains(i))
                {
                    continue;
                }
                return i;
            }
            return 1;
        }

        /* 4.     მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან. დაწერეთ ფუნქცია რომელიც აბრუნებს 
         * ფრჩხილები არის თუ არა მათემატიკურად სწორად დასმული.*/

        public static bool IsProperly(String sequence)
        {
            int counter = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if(counter < 0)
                {
                    return false;
                }
                if(sequence[i] == '(')
                {
                    counter++;
                }
                if (sequence[i] == ')')
                {
                    counter--;
                }
            }
            if(counter!= 0)
            {
                return false;
            }
            return true;
        }

        /* 5.     გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2 საფეხურით. დაწერეთ ფუნქცია რომელიც
         * დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.*/
        
        public static int CountVariants(int stearsCount)
        {
            List<int> list = new List<int>();

            // თუ თვლას ვიწყებთ 0 საფეხურიდან, ანუ შეგვიძლია გადახტომა პირველ ან მეორე საფეხურზე
            list.Add(1); // list[0] = 1
            // პირველ საფეხურზე მხოლოდ ერთი გზა არსებობს 0-დან ერთამდე
            list.Add(1);  // list[1] = 1  
            for (int i = 2; i < stearsCount; i++)
            {
                //  list[i] =  წინა 2 რიცხვის ჯამის
                list.Add(list[i - 1] + list[i - 2]);

            }
            return list.Last();
        }

        /*6.  დაწერეთ საკუთარი მონაცემთა სტრუქტურა, რომელიც საშუალებას მოგვცემს O(1) დროში წავშალოთ ელემენტი.*/

        public static bool DeleteFromData(int index)
        {
            MyDataStructure data = new MyDataStructure();
            return data.RemoveAt(index);
        }


        public static double Exchange(string from , string to)
        {
            /* 
              1. გავაკეთოთ რიქვესთი საიტზე
              2. წავიკითხოთ მონაცემები
              3. შევადგინოთ კავშირი from და to-ს შორის 
            */

            
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead("http://www.nbg.ge/rss.php");
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            XmlDocument xmlDoc = new XmlDocument(); 
            xmlDoc.LoadXml(s); 
            XmlNodeList items = xmlDoc.GetElementsByTagName("item");

            var table = items.Item(0).ChildNodes.Item(2).ChildNodes.Item(0).InnerText;
            string strRegex = @"<td>([^<]+)";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            MatchCollection valutes = re.Matches(table);

            List<Valute> valutesList = new List<Valute>();
            Valute curValute = new Valute();

            int index = 1;
            foreach (Match collection in valutes)
            {
                var value = collection.Groups[1].Value;

                if(index == 1)
                {
                    curValute.Name = value;
                }
                else if(index == 3)
                {
                    curValute.Value = value;
                    valutesList.Add(curValute);
                    curValute = new Valute();
                }
                index %= 4;
                index++;
            }
            var fromValute = valutesList.Find(valute => valute.Name == from);
            var toValute = valutesList.Find(valute => valute.Name == to);
            if(fromValute == null || toValute == null)
            {
                throw new Exception("Aseti valuta ar arsebobs");
            }
            return Convert.ToDouble(fromValute.Value) / Convert.ToDouble(toValute.Value);
        }
        
    }
}

