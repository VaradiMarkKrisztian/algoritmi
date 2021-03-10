using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm_curs2_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"suma maxima este { ex1()}"); //maximum absolute difference
            ex2(); //add 1 to number
            Console.ReadKey();
        }

        private static void ex2()
        {
            Console.WriteLine("Introduceti capacitatea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i;
            Console.WriteLine("introduceti numarul ca si vector");
            for(i=0;i<v.Length;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("vectorul initial este");
            WriteArray(v);
            Console.WriteLine();
            Console.WriteLine("rezultatul este ");
            AddOneToVector(v);
            
           
        }

        private static void AddOneToVector(int[] v)
        {
            if(v.Length==0)
            {
                Console.Write("Nu exista valori in vector");
                return;
            } 
            int carry = 0;
            int n = v.Length;
            if(v[n - 1] + 1>=10)
            {
                carry = 1;
            }
            v[n - 1] = (v[n - 1] + 1) % 10; //%10 ia ultima cifra din nr
            for (int  i = n-2;  i >=0;  i--)
            {
                int aux = v[i] + carry;
                if (carry == 1)
                {
                    v[i] = aux % 10;
                    carry = aux / 10;
                }
            }
            
            if(carry==1)
            {
                Array.Resize(ref v,n + 1);
                v[0] = carry; //resize creaza un vector care are primele n elem cu val 0. 
                //ex v original= 1000, resize v de n+1 =01000 
            }
            WriteArray(v);
        }

        private static void WriteArray(int []v)
        {
            
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        private static int ex1()
        {
            Console.WriteLine("maximum absolute difference");
            Console.WriteLine("introduceti marimea vectorului");
            //int n = int.Parse(Console.ReadLine());
            //int[] v = new int[n];
            int i, j;
            int[] v = new int[] { 1, 3, -1 };
            Console.WriteLine("Elementele vectorului sunt ");
            for( i=0;i<v.Length;i++)
            {
                Console.Write(v[i] + " ");
            }
            int suma = 0;
            int max = 0;
            
            for(i=1;i<v.Length;i++)
            {
                for(j=2;j<v.Length;j++)
                {
                    suma = Math.Abs(v[i] - v[j]) + Math.Abs(i - j);
                    if (suma > max) max = suma;
                }
                j++; 
            } 
            Console.WriteLine();
            return max;
        }
    }
}
