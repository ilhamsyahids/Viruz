using System;
using System.Collections.Generic;

//namespace Viruz
//{
public partial class Algorithm
{
    Dictionary<string, List<Tuple<string, double>>> adj;
    Dictionary<string, int> populasi;
    string asal;
    int time;

    public Algorithm(Dictionary<string, int> populasi, Dictionary<string, List<Tuple<string, double>>> adj, string asal, int timeLimit)
    {
        this.populasi = populasi;
        this.adj = adj;
        this.asal = asal;
        this.time = timeLimit;
    }

    public static double fungsiLogistik(int populasi, int time)
    {
        return (1.0) * populasi / (1 + (populasi - 1) * Math.Exp(-0.25 * time));
    }

    public void solve() {
        bfs(this.populasi, this.adj, this.asal, this.time);
    }

    public void bfs(Dictionary<string, int> populasi, Dictionary<string, List<Tuple<string, double>>> adj, string asal, int timeLimit)
    {
        string u;

        Dictionary<string, int> time = new Dictionary<string, int>();
        Dictionary<string, bool> isTertular = new Dictionary<string, bool>();

        foreach (KeyValuePair<string, int> e in populasi)
        {
            time.Add(e.Key, 999999999);
            isTertular.Add(e.Key, false);
        }
        time[asal] = 0;
        isTertular[asal] = true;

        Queue<string> q = new Queue<string>();
        q.Enqueue(asal);
        while (q.Count != 0)
        {
            u = q.Dequeue();
            foreach (Tuple<string, double> v in adj[u])
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

        foreach (KeyValuePair<string, bool> e in isTertular)
        {
            if (e.Value == true)
            {
                Console.WriteLine(e.Key + " = " + time[e.Key]);
            }
        }
    }

    //public static void solve()
    //{
    //    string u, v, asal;
    //    double peluang;
    //    int x, jumlahNegara;

    //    Console.Write("Masukkan jumlah edges: ");
    //    int jumlahEdges = Convert.ToInt32(Console.ReadLine());
    //    Dictionary<string, List<Tuple<string, double>>> adj = new Dictionary<string, List<Tuple<string, double>>>();

    //    for (int i = 0; i < jumlahEdges; ++i)
    //    {
    //        Console.Write("masukkan kota asal" + "Ke-" + i + ": ");
    //        u = Convert.ToChar(Console.ReadLine());

    //        Console.Write("masukkan kota tujuan" + "Ke-" + i + ": ");
    //        v = Convert.ToChar(Console.ReadLine());

    //        Console.Write("peluang: ");
    //        peluang = double.Parse(Console.ReadLine());
    //        var tuple1 = new Tuple<string, double>(v, peluang);
    //        if (!adj.ContainsKey(u))
    //        {
    //            List<Tuple<string, double>> tempList = new List<Tuple<string, double>>();
    //            tempList.Add(tuple1);
    //            adj[u] = tempList;
    //        }
    //        else
    //        {
    //            adj[u].Add(tuple1);

    //        }

    //    }

    //    Console.WriteLine("ilustrasi graphnya");
    //    foreach (KeyValuePair<string, List<Tuple<string, double>>> kvp in adj)
    //    {
    //        Console.WriteLine(kvp.Key);
    //        foreach (Tuple<string, double> el in kvp.Value)
    //        {
    //            Console.WriteLine(kvp.Key + " -> " + el.Item1 + " : " + el.Item2);
    //        }
    //    }

    //    Dictionary<string, int> populasi = new Dictionary<string, int>();

    //    Console.Write("Masukkan jumlah negara: ");
    //    jumlahNegara = Convert.ToInt32(Console.ReadLine());

    //    Console.Write("Masukkan negara asal: ");
    //    asal = Convert.ToChar(Console.ReadLine());
    //    for (int i = 0; i < jumlahNegara; ++i)
    //    {
    //        Console.Write("Negara " + "Ke - " + i + ": ");
    //        u = Convert.ToChar(Console.ReadLine());

    //        Console.Write("Populasi: ");
    //        x = Convert.ToInt32(Console.ReadLine());
    //        populasi.Add(u, x);
    //    }

    //    Console.Write("masukkan batas waktu: ");
    //    int timeLimit = Convert.ToInt32(Console.ReadLine());
    //    bfs(populasi, adj, asal, timeLimit);
    //}
}
//}
