using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Dictionary<string, List<Tuple<string, double>>> adj;
    Dictionary<string, int> populasi;
    string asal;
    int time;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void exit(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void Check1(object sender, EventArgs e)
    {
        try
        {
            textview3.Buffer.Text += "[INFO]Checking File 1...\n";
            string text = "";
            string ext = System.IO.Path.GetExtension(filechooserwidget1.Filename);
            if (ext != ".txt")
            {
                throw new Exception("[WARNING]File 1 is not .txt\n");
            }
            string[] lines = System.IO.File.ReadAllLines(filechooserwidget1.Filename);

            foreach (string line in lines)
            {
                text += line + "\n";
            }

            textview1.Buffer.Text = text;
            textview3.Buffer.Text += "[INFO]Checking File 1 done\n";
        }
        catch (Exception err)
        {
            textview3.Buffer.Text += err.Message;
            textview3.Buffer.Text += "[ERROR]Checking File 1 failed\n";
        }
    }

    protected void Check2(object sender, EventArgs e)
    {
        try
        {
            string text = "";
            textview3.Buffer.Text += "[INFO]Checking File 2...\n";
            string ext = System.IO.Path.GetExtension(filechooserwidget2.Filename);
            if (ext != ".txt")
            {
                throw new Exception("[WARNING]File 2 is not .txt\n");
            }
            string[] lines = System.IO.File.ReadAllLines(filechooserwidget2.Filename);

            foreach (string line in lines)
            {
                text += line + "\n";
            }

            textview2.Buffer.Text = text;
            textview3.Buffer.Text += "[INFO]Checking File 2 done\n";
        }
        catch (Exception err)
        {
            textview3.Buffer.Text += err.Message;
            textview3.Buffer.Text += "[ERROR]Checking File 2 failed\n";
        }
    }

    protected void Read1(object sender, EventArgs e)
    {
        try
        {
            textview3.Buffer.Text += "[INFO]Reading File 1...\n";
            string U, V;
            double peluang;
            int pointer = 0;
            string[] text = textview1.Buffer.Text.Split('\n', ' ');
            
            int edges = int.Parse(text[pointer++]);
            textview3.Buffer.Text += "Jumlah Edges: " + edges + "\n";
            Dictionary<string, List<Tuple<string, double>>> adj = new Dictionary<string, List<Tuple<string, double>>>();

            for (int i = 0; i < edges; i++)
            {
                U = text[pointer++];
                textview3.Buffer.Text += U + " ";
                V = text[pointer++];
                textview3.Buffer.Text += V + " ";
                double.TryParse(text[pointer++], NumberStyles.Any, CultureInfo.InvariantCulture, out peluang);
                textview3.Buffer.Text += peluang + "\n";
                var tuple1 = new Tuple<string, double>(V, peluang);
                if (!adj.ContainsKey(U))
                {
                    List<Tuple<string, double>> tempList = new List<Tuple<string, double>>();
                    tempList.Add(tuple1);
                    adj[U] = tempList;
                }
                else
                {
                    adj[U].Add(tuple1);

                }
            }

            Microsoft.Msagl.Drawing.Graph peta = new Microsoft.Msagl.Drawing.Graph("");
            Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer(peta);

            this.adj = adj;
            textview3.Buffer.Text += "\nIlustrasi Graph :\n";
            foreach (KeyValuePair<string, List<Tuple<string, double>>> kvp in adj)
            {
                textview3.Buffer.Text += kvp.Key + "\n";
                foreach (Tuple<string, double> el in kvp.Value)
                {
                    textview3.Buffer.Text += kvp.Key + " ->  " + el.Item1 + " : " + el.Item2 + "\n";
                }
            }
            textview3.Buffer.Text += "[INFO]Read File 1 done\n";
                        
            renderer.CalculateLayout();
            int width = 1000;
            Bitmap bitmap = new Bitmap(width, (int)(peta.Height * (width / peta.Width)), PixelFormat.Format32bppPArgb);
            renderer.Render(bitmap);
            bitmap.Save("peta.png");


        } catch (Exception err)
        {
            textview3.Buffer.Text += err.Message + "\n";
            textview3.Buffer.Text += "[ERROR]Reading File 1 failed\n";
        }
    }

    protected void Read2(object sender, EventArgs e)
    {
        try
        {
            textview3.Buffer.Text += "[INFO]Reading File 2...\n";
            int count, jumlahNegara, pointer = 0;
            string U, asal;
            Dictionary<string, int> populasi = new Dictionary<string, int>();
            string[] text = textview2.Buffer.Text.Split('\n', ' ');

            jumlahNegara = int.Parse(text[pointer++]);
            textview3.Buffer.Text += "Jumlah negara: " + jumlahNegara + "\n";

            asal = text[pointer++];
            textview3.Buffer.Text += "Asal negara: " + asal + "\n";

            for (int i = 0; i < jumlahNegara; ++i)
            {
                U = text[pointer++];
                count = Convert.ToInt32(text[pointer++]);
                populasi.Add(U, count);
                textview3.Buffer.Text += U + " " + count + "\n";
            }

            this.asal = asal;
            this.populasi = populasi;
            textview3.Buffer.Text += "[INFO]Read File 2 done.\n";
        }
        catch (Exception err)
        {
            textview3.Buffer.Text += err.Message + "\n";
            textview3.Buffer.Text += "[ERROR]Reading File 2 failed\n";
        }
    }

    protected void Solve(object sender, EventArgs e)
    {
        try
        {
            int time = int.Parse(entry1.Text);
            textview3.Buffer.Text += "Time Limit: " + time + "\n";
            Algorithm algo = new Algorithm(this.populasi, this.adj, this.asal, time);
            algo.solve();
            var buffer = System.IO.File.ReadAllBytes("../../black.jpg");
            var pixbuf = new Gdk.Pixbuf(buffer);
            image1.Pixbuf = pixbuf;
        } catch (Exception err)
        {
            textview3.Buffer.Text += err.Message + "\n";
            textview3.Buffer.Text += "[ERROR]Solving failed\n";
        }
    }
}
