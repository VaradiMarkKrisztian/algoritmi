using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_curs2
{
    class Program 
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("dati nr N");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(10);
            }
            int result= ex2normal(v); // aduna elem vector
            Console.WriteLine( result);
            Console.WriteLine("Recursiv");
            int result2=ex2recursiv(v,-1); //aduna elem vector
            Console.WriteLine(result2);
            Console.WriteLine("introduceti nr de rotatii");
            int rotatii = int.Parse(Console.ReadLine());
            //rotatii vector
            if(rotatii==0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(v[i] + " ");
                }
            }
            int[] aux = new int[n];
            int j = 0;
            for (int i = rotatii; i < n; i++)
            {
                aux[j] = v[i];
                j++;
            }
            for (int i = 0; i < rotatii; i++)
            {
                aux[j] = v[i];
                j++;
            }
            for(int i=0;i<n;i++)
            {
                Console.Write(aux[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.ReadKey();
           
        }

        private static int ex2recursiv(int[]v,int index)
        {
            if (index == v.Length)
            { return 0; }
            index++;
            return v[index] + ex2recursiv(v, index + 1);
        }

        private static int ex2normal(int[]v)
        {

            int sum = 0;
            for(int i=0;i<v.Length;i++)
            {
                sum = sum + v[i];
            }
            return sum;
        } 
    }
}

