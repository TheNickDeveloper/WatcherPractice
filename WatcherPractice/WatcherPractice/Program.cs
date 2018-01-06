using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatcherPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            WtacherHelper clsWatcher = new WtacherHelper(@"C:\Users\32355\Desktop\WatchPractice","*txt");
            clsWatcher.WatchStart();
            Console.ReadKey();
        }
    }
}
