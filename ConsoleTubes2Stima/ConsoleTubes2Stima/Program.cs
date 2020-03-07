using System;
using System.Collections.Generic;

namespace ConsoleTubes2Stima
{
    class Program
    {
        public static double fungsiLogistik(int populasi, int time)
        {
            return (1.0) * populasi / (1 + (populasi - 1) * Math.Exp(-0.25 * time));
        }

        public static void bfs(Dictionary<char, int> populasi, Dictionary<char, List<Tuple<char, double>>> adj, char asal, int timeLimit)
        {
            int t;
            char u;

            Dictionary<char, int> time = new Dictionary<char, int>();
            Dictionary<char, bool> isTertular = new Dictionary<char, bool>();

            foreach (KeyValuePair<char, int> e in populasi)
            {
                time.Add(e.Key, 999999999);
                isTertular.Add(e.Key, false);
            }
            time[asal] = 0;
            isTertular[asal] = true;

            Queue<char> q = new Queue<char>();
            q.Enqueue(asal);
            while (q.Count != 0)
            {
                u = q.Dequeue();
                foreach (Tuple<char, double> v in adj[u])
                {

                    if (fungsiLogistik(populasi[u], timeLimit - time[u]) * v.Item2 > 1)
                    {
                        for (int waktuPenularan = 0; waktuPenularan <= timeLimit - time[u]; waktuPenularan++)
                        {
                            if (fungsiLogistik(populasi[u], waktuPenularan) * v.Item2 > 1)
                            {
                                int tnew = waktuPenularan + time[u];
                                if (tnew <= time[v.Item1])
                                {
                                    time[v.Item1] = tnew;
                                    isTertular[v.Item1] = true;
                                    q.Enqueue(v.Item1);
                                }

                                break;
                            }
                        }

                    }

                }
            }

            Console.WriteLine("Yang tertular");

            foreach(KeyValuePair<char,bool> e in isTertular)
            {
                if (e.Value == true)
                {
                    Console.WriteLine(e.Key + " = "+ time[e.Key]);
                }
            }
        }


   
        public static void solve()
        {
            char u, v, asal;
            double peluang;
            int x, jumlahNegara;

            Console.Write("Masukkan jumlah edges: ");
            int jumlahEdges = Convert.ToInt32(Console.ReadLine());
            Dictionary<char, List<Tuple<char, double>>> adj = new Dictionary<char, List<Tuple<char, double>>>();

            for (int i = 0; i<jumlahEdges; ++i)
            {
                Console.Write("masukkan kota asal"+ "Ke-" +i+": ");
                u = Convert.ToChar(Console.ReadLine());

                Console.Write("masukkan kota tujuan"+ "Ke-"+ i+ ": ");
                v = Convert.ToChar(Console.ReadLine());

                Console.Write("peluang: ");
                peluang = double.Parse(Console.ReadLine());
                var tuple1 = new Tuple<char, double>(v, peluang);
                if (!adj.ContainsKey(u))
                {
                    List<Tuple<char, double>> tempList = new List<Tuple<char, double>>();
                    tempList.Add(tuple1);
                    adj[u] = tempList;
                }
                else
                {
                    adj[u].Add(tuple1);
                    
                }
                
            }

            Console.WriteLine("ilustrasi graphnya");
            foreach (KeyValuePair<char, List<Tuple<char, double>>> kvp in adj)
            {
                Console.WriteLine(kvp.Key);
                foreach (Tuple<char, double> el in kvp.Value)
                {
                    Console.WriteLine(kvp.Key+ " -> "+ el.Item1 + " : " + el.Item2);
                }
            }

            Dictionary<char, int> populasi = new Dictionary<char, int>();

            Console.Write("Masukkan jumlah negara: ");
            jumlahNegara = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan negara asal: ");
            asal = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i<jumlahNegara; ++i)
            {
                Console.Write("Negara " + "Ke - "+ i+ ": ");
                u = Convert.ToChar(Console.ReadLine());

                Console.Write("Populasi: ");
                x = Convert.ToInt32(Console.ReadLine());
                populasi.Add(u, x);
            }

            Console.Write("masukkan batas waktu: ");
            int timeLimit = Convert.ToInt32(Console.ReadLine());
            bfs(populasi, adj,asal, timeLimit);
        }
        static void Main(string[] args)
        {
            solve();
        }
    }
}
