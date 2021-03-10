using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm_curs4_matrici
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {       //toate elem de pe diag secundara i+j = n-1
                //toate elem de pe diag principala i == j
                // elem deasupra diag principala   i < j
                //elem sub diag principala         i > j
                //elem sub diag secundara          i+j > n-1
                //elem deasupra diag secundara     i+j < n-1
                //ex1(); //afiseaza matricea dupa pozitia fata de diagonala ^     GOOD
                //ex2(); //creati si afisati conturul                             GOOD
                //ex3(); //min de pe fiecare linie si minimul maxim dintre ele    GOOD
                //ex4(); //creati un vector care are un nr min pe pozitia care nu apare pe linia si coloana aceea     ???
           // ex5(); //elem de pe linie sa fie inversate  GOOD
                //i=0 -> j-1
                //j=0 -> i-1
            Console.ReadKey();


        }

        private static void ex5()
        {
            int n = 1234567;
            int[] v = new int[10];
            int save_n = n;
            int nrc = 0;
            while (n!=0) //se pun cifrele numarului in vector si se creaza dimensiunea vectorului
            {
                v[nrc] = n % 10;
                nrc++;
                n = n / 10;
            }
            int[,] a = new int[nrc, nrc]; //crearea matricei patratice cu dimensiunea vectorului [6,6]
            for (int i = 0; i < nrc; i++)
            {
                for (int j = 0; j < nrc; j++) //se inverseaza elementele de pe linie
                    a[i, j] = v[j];
            }
            for (int i = 0; i < nrc; i++)
            {
                for (int j = 0; j < nrc; j++)
                    Console.Write(a[i,j]+" ");
                Console.WriteLine();                
            }
        }

        private static void ex4()
        {
            int n = 10;
            int[,] v = new int[n, n];
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    bool[] vn = new bool[n * n];  
                    for (int k = 0; k < n * n; k++) vn[k] = false;
                    for (int k = 0; k < i; k++)                   
                        vn[v[k, j]] = true;
                    int idx = 0;
                    while (vn[idx]) idx++;
                    v[i, j] = idx;
                }    
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(v[i,j]+" "); 
                Console.WriteLine();
            }
           
        }

        private static void ex3()
        {
            int n = 5;
            int m = 7;
            int[,] v = new int[n, m];
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    v[i, j] = rnd.Next(10);
                }
            }
            for ( i = 0; i < n; i++)
            {
                for ( j = 0; j < m; j++)              
                    Console.Write(v[i,j]+" ");
                Console.WriteLine();
            }
            int max = 0;
            for (i = 0; i < n; i++)
            {
                int min = v[i, 0];
                for ( j = 1; j < m; j++)
                {
                    if (v[i, j] < min) min = v[i, j];
                }
                if (min > max) max = min;
            }
            Console.Write(max);
        }

        private static void ex2()
        {
            //primul vector 0->n-2  (prima linie)
            //al doilea vector 0 -> n-2 (ultima coloana)
            //al treilea vector n-1 -> 1 (ultima linie)
            //al patrulea vector n-1 -> 1 (prima coloana)
            int n = 8;
            int m = 7;
            int k = 1;
            int[,] a = new int[n, m];
            int i, j;
            for ( i = 0; i < n; i++)
            {
                for ( j = 0; j < m; j++)
                {
                    a[i, j] = k;
                    k++;
                    if (k == 10) k = 1;
                }
            }
            for (i= 0; i < n; i++)
            {
                for ( j = 0; j < m; j++)
                 Console.Write(a[i, j] + " ");               
                Console.WriteLine();
            }
            //0  i
            //1
            //2
            //...
            //n-1
            Console.WriteLine();
            Console.WriteLine("Prima linie ");
            for ( i = 0; i <m-1; i++)
                Console.Write(a[0,i]+" ");
            Console.WriteLine();
            Console.WriteLine("ultima coloana");
            for ( i = 1; i < n-1; i++)   
                Console.Write(a[i, a.GetLength(1) - 1] +" ");   //GetLength(n) = linia lui n, aici getlength(1)= 8, getlength(1)-1 = 7 ?
            Console.WriteLine();
            Console.WriteLine("ultima linie");
            for ( j = m-1; j >=1 ; j--)
                Console.Write(a[n-1,j]+" ");
            Console.WriteLine();
            Console.WriteLine("prima coloana");
            for ( i = n-1; i >=1 ; i--)
                Console.Write(a[i,0]+" ");      
        }

        private static void ex1()
        {
            int n = 9;
            int[,] v = new int[n, n];
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {   //Console.Write(i+" "+j + " "); //afiseaza elem dupa pozitia (linie coloana
                    if ((i < j) && (i + j < n - 1))
                        v[i, j] = 1;
                    if ((i < j) && (i + j > n - 1))
                        v[i, j] = 2;
                    if ((i > j) && (i + j < n - 1))
                        v[i, j] = 4;
                    if ((i > j) && (i + j > n - 1))
                        v[i, j] = 3;
                }
            }
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++) Console.Write(v[i, j] + " ");

                    Console.WriteLine();
                }           
        }
    }
}
