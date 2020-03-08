using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
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
            textview3.Buffer.Text += "Checking File 1...\n";
            string[] lines = System.IO.File.ReadAllLines(filechooserwidget1.Filename);

            string text = "";

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                text += line + "\n";
            }

            textview1.Buffer.Text = text;
            textview3.Buffer.Text += "Checking File 1 done\n";
        }
        catch
        {
            textview3.Buffer.Text += "Checking File 1 failed\n";
            textview1.Buffer.Text = "Something went wrong";
        }
    }

    protected void Check2(object sender, EventArgs e)
    {
        try
        {
            textview3.Buffer.Text += "Checking File 1...\n";
            string[] lines = System.IO.File.ReadAllLines(filechooserwidget2.Filename);

            string text = "";

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                text += line + "\n";
            }

            textview2.Buffer.Text = text;
            textview3.Buffer.Text += "Checking File 1 done\n";
        }
        catch
        {
            textview3.Buffer.Text += "Checking File 1 failed\n";
            textview2.Buffer.Text = "Something went wrong";
        }
    }
}
