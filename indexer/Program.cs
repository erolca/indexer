using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* genel yapı....
 * element-type this[int index]
{
   // The get accessor.
   get
   {
      // return the value specified by index
   }
   
   // The set accessor.
   set
   {
      // set the value specified by index
   }
}
*/

namespace indexer
{
    class Insan
    {
        static public int size = 10;
        string[] isimler = new string[size];

        public Insan()
        {
            for (int i = 0; i < size; i++)
                isimler[i] = "N.A";
        }
       

        public string this[int i]
        {
            get
            {
                return isimler[i];
            }

            set
            {

                isimler[i] = value;
            }
        }



    }





    class Program
    {
        static void Main(string[] args)
        {

            Insan insan = new Insan();
            insan[3] = "Erolca";
            insan[5] = "Erol";

            Console.WriteLine(insan[3]);
            Console.WriteLine(insan[5]);




        }
    }
}
