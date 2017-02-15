using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class MyHomework : object
    {
        private int _myNumValue;

        private const int MyConstValue = int.MaxValue;
        public string MyTxtValue { get; private set; }
        public bool MyBoolValue { get; set; }
        public enum Enums { };

        public void SetMyNumValue()
        {
            Console.WriteLine("Enter a random number");

            int numValue = Convert.ToInt32(Console.ReadLine());

            _myNumValue = numValue;
        }

        public string MyHelperMetho()
        {
            Console.WriteLine("Enter something");
            string txtValue = Console.ReadLine();
            string output = new string(txtValue.ToCharArray().Reverse().ToArray());
            return output;
        }

        public dynamic MyPolyMethod()
        {
            string[] randomStrings = new string[20];
            for (int i = 0; i < randomStrings.Length; i++)
            {
                randomStrings[i] = Console.ReadLine();
            }
            IEnumerable<Enums> items = randomStrings.Select(a => (Enums)Enum.Parse(typeof(Enums), a));
            return items;
        }

        public static bool Shorten(string text, int n, out bool result)
        {
            if (string.IsNullOrEmpty(text))
            {
                result = false;
            }

            else
            {
                text.Substring(0, Math.Min(text.Length, n));
                result = true;
            }
            return result;
        }
    }
}
