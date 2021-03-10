using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace algoritmi_curs1
{
    class Program
    { //vector palindrom
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //palindrom();
            //sumacifnrprime();
            //celemaimariKnr();
            //numerotareelementvector();
            //ex3(); //puteri a lui 2, numere perfecte, perechi de nr prime
            ex4(); //cele mai mari K valori de 3 cifre ce nu apar in vector
            
            }

        private static void ex4()
        {
            
            int n = 1000;
            int k = 7;
            int[] v = new int[n];
            for(int i=0;i<n;i++)
             v[i] = rnd.Next(0, 500);
            bool[] vn = new bool[1000];
            int nat = 0;
            
            for(int i=0;i<n;i++)
            {
                if (v[i] >= 0 && v[i] <= 999)
                {
                    { 
                    vn[v[i]] = true;
                    nat++;
                    }
                }
            }
            if (900 - nat >= k)
            {
                int nrafisat = 0;
                for (int i = 999; i >= 100; i--)
                {
                    if (!vn[i])
                    {
                        Console.Write(i + " ");
                        nrafisat++;
                        if (nrafisat == k) break;
                    }
                }
            }
            else Console.Write("nu exista");
            Console.ReadKey();
        }

        private static void ex3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            //puterile lui 2
            Console.WriteLine("puteri ale lui 2 sunt: ");

            for (int i = 0; i < n; i++)
            {
                int putere = 1;
                while (putere <= v[i])
                {
                    if (v[i] == 1) Console.WriteLine(v[i] + " ");
                    putere = putere * 2;
                    if (v[i] == putere) Console.WriteLine(v[i] + " ");
                }
            }
            //numerele perfecte (suma divizorilor = numarul)
            Console.WriteLine("Numere perfecte sunt: ");
            for (int i = 0; i < n; i++)
            {
                int k;
                int suma = 0;
                for (k = 1; k <= v[i] / 2; k++)
                {
                    if (v[i] % k == 0) suma = suma + k;
                }

                if (v[i] == suma) Console.WriteLine(v[i] + " ");
            }
            //perechi de nr prime
            Console.WriteLine("Perechi de nr prime sunt: ");
            for (int i = 0; i < n; i++)
            {
                if (prime(v[i]))
                {
                    Console.Write(v[i] + " ");
                }
                else Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static void numerotareelementvector()
        {
            //de cate ori apare fiecare elem
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int x = v[0];
            int k = 1;
            for (int i = 1; i < n; i++)
            {
                if (v[i] == x) k++;
                else
                {
                    Console.Write(x + " " + k + " ");
                    k = 1;
                }
                x = v[i];
            }
            Console.Write(x + " " + k + " "); //sa se afiseze si ultimul grup de elemente      
            Console.ReadKey();
        }

        private static void celemaimariKnr()
            {
                //cele mai mari k nr care nu apar in vector
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int[] r = new int[2 * n];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                    Console.Write(v[i] + " ");
                    //v[i] = rnd.Next(100);

                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    r[k] = v[i];
                    k++;
                    if (prime(v[i]))
                    {
                        r[k] = sumacif(v[i]);
                        k++;
                    }
                }
                for (int i = 0; i < k; i++) Console.Write(v[i] + " ");
                Console.ReadKey();
            }

            private static void sumacifnrprime()
            {
                //suma cifre lui nr prim dupa fiecare nr prim
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                    //v[i] = rnd.Next(100);
                }
                for (int i = 0; i < n; i++)
                {
                    if (prime(v[i])) Console.Write(v[i] + " " + sumacif(v[i]) + " ");
                }
                Console.ReadKey();
            }

            /* private static bool prime(int n)
             { //O(n)
                 int nrd = 0;
                 for (int i = 1; i <= n; i++)
                     if ((n % i) == 0) nrd++;
                 if (nrd == 2) return true;
                 return false;
             } */
            private static bool prime(int n) //metoda eficienta pt nr prime
            {
                if (n < 2) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false;
                for (int i = 3; i * i <= n; i += 2)  //math.sqrt(n) == n/2
                    if (n % i == 0) return false;
                return true;
            } //! algoritmi de probabilitate
            private static int sumacif(int n)
            {
                int tor = 0;
                while (n != 0)
                {
                    tor = tor + n % 10;
                    n = n / 10;
                }
                return tor;
            }

            private static void palindrom()
            {
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                    //v[i] = rnd.Next(100);
                }
                bool ok = true;
                for (int i = 0; i < n / 2; i++)
                {
                    if (v[i] != v[n - 1 - i]) ok = false;
                    break;
                }
                if (ok)
                    Console.WriteLine("DA");
                else Console.WriteLine("NU");
                Console.ReadKey();
            }
    }
}
    
