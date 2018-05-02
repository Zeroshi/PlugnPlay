using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string a = Swap("Ganesh","AlalaSundaram",0,0);
            Console.WriteLine(a);
         }

        public static string Swap(string firsttext,string secondtext,int firstposition,int lastposition)
        {
            char[] a = firsttext.ToCharArray();
            char[] b = secondtext.ToCharArray();
            var temp = a[firstposition];
            a[firstposition] = b[lastposition];
            b[lastposition] = temp;
            return new string(a);
        }
    }
}
