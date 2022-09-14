using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Math2
{
    public static class Math2
    {



        public static int Min(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else  
            {
                return y;
            }
           

        }

        public static int Max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public static bool AreEqual(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else { return false; }

        }

        public static int Sum(int x, int y)
        {

            return x + y;

        }

        public static void Swap(int x, int y)
        {
                int aux;

                aux = y;
                y = x;
                x = aux;

            Console.WriteLine("Após troca de valores: x = " + x + " e y = " + y);
            



        }


        
    }
}    
 