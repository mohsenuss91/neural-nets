using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YapaySinirAgi_HebbNet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            System.IO.StreamReader stdin =
                new System.IO.StreamReader(Console.OpenStandardInput());
            if (args.Length != 0)
            {
                Console.SetIn(new System.IO.StreamReader(args[0]));
            }
            Console.WriteLine("Hebb Net yapay sinir ağı uygulaması");
            Console.WriteLine("Öğrenme vektörlerinin sayısını girin :");
            int nGirdi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vektör değişkeni sayısını girin :");
            int p = Convert.ToInt32(Console.ReadLine());

            double[,] x = new double[nGirdi, p];
            double[] t = new double[nGirdi];
            double[] w = new double[p];
            for (int i = 0; i < p; i++)
                w[i] = 0.0;
            double b = 0.0;
            double[] s = new double[p];
            double[] y = new double[nGirdi];

            while (running)
            {
                Console.WriteLine("\n> Öğretici örüntü girmek için 1, sorgu için 2, çıkmak için 3:");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Öğretici örüntüyü girin ({0} eleman):", nGirdi);
                        for (int i = 0; i < nGirdi; i++)
                        {
                            string tmp1 = Console.ReadLine();
                            for (int j = 0; j < p; j++)
                                x[i, j] = Convert.ToDouble(tmp1.Split(' ', ',')[j]);
                        }

                        Console.WriteLine("Beklenen sonuçları girin ({0} eleman):", nGirdi);
                        for (int i = 0; i < nGirdi; i++)
                        {
                            t[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        for (int i = 0; i < nGirdi; i++)
                        {
                            y[i] = t[i];
                            for (int j = 0; j < p; j++)
                            {
                                w[j] = w[j] + x[i, j] * y[i];
                            }
                            b = b + y[i];
                        }
                        Console.WriteLine("b = {0}", b);
                        for (int i = 0; i < p; i++)
                            Console.WriteLine("w[{0}] = {1}", i, w[i]);
                        break;
                    case 2:
                        Console.WriteLine("Sorgu elemanını girin :");
                        string tmp2 = Console.ReadLine();
                        for (int i = 0; i < p; i++)
                            s[i] = Convert.ToDouble(tmp2.Split(' ', ',')[i]);
                        double sonuc = b;
                        for (int i = 0; i < p; i++)
                            sonuc += s[i] * w[i];
                        Console.WriteLine("Çıktı : {0}", sonuc);
                        break;
                    case 3:
                        Console.SetIn(stdin);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
