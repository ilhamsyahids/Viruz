using System;
using System.Collections.Generic;

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

    public List<Tuple<string, int, int>> solve() {
        return bfs(this.populasi, this.adj, this.asal, this.time);
    }

    public List<Tuple<string, int, int>> bfs(Dictionary<string, int> populasi, Dictionary<string, List<Tuple<string, double>>> adj, string asal, int timeLimit)
    {
        string u, result;

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

        //Console.WriteLine("Yang tertular");
        result = "Yang tertular\n";
        List<Tuple<string, int, int>> T = new List<Tuple<string, int, int>>();
        foreach (KeyValuePair<string, bool> e in isTertular)
        {
            if (e.Value == true)
            {
                int populasiNow = (int)Math.Floor(fungsiLogistik(populasi[e.Key], timeLimit - time[e.Key]));
                //Console.WriteLine(e.Key + " t= "+ time[e.Key] + " banyaknya = " + populasiNow);
                result += e.Key + " saat " + time[e.Key] + " satuan waktu dengan banyak yang tertular: " + populasiNow + "\n";
                T.Add(new Tuple<string, int, int>(e.Key, time[e.Key], populasiNow));
            }
        }
        return T;
    }
}
