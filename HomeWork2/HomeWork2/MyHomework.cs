using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class MyHomework : object
    {
        private int _myNumValue;

        private const int MyConstValue = int.MaxValue;
        public string MyTxtValue { get; private set; }
        public bool MyBoolValue { get; set; }

        public void SetMyNumValue()
        {
            Console.WriteLine("Enter a random number");

            int numValue = Convert.ToInt32(Console.ReadLine());

            _myNumValue = numValue;
        }

        public void MyHelperMethod()
        {
            string txtValue;
            Console.WriteLine("Enter somethint");
            txtValue = Console.ReadLine();

            return;
        }

        public void MyPolyMethod()
        {
            string[] randomStrings;

        }
    }
}
