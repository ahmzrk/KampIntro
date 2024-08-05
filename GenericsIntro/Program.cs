using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Count);
            isimler.Add("İsmet");
            Console.WriteLine(isimler.Count);

            foreach (var item in isimler.Items) 
            {
                Console.WriteLine(item);
            }
        }


        
    }
}
