using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public sealed class MyExecutor : MyHomework
    {
        static void Main()
        {
            MyHomework homeWork = new MyHomework();
            Console.WriteLine("Start");

            homeWork.SetMyNumValue();

            Console.WriteLine("End");
        }
    }
}
