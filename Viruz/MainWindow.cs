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
            string text = "";
            textview3.Buffer.Text += "Checking File 1...\n";
            string ext = System.IO.Path.GetExtension(filechooserwidget1.Filename);
            if (ext != ".txt")
            {
                textview3.Buffer.Text += "File 1 is not .txt\n";
                return;
            }
            string[] lines = System.IO.File.ReadAllLines(filechooserwidget1.Filename);

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
            string text = "";
            textview3.Buffer.Text += "Checking File 2...\n";
            string ext = System.IO.Path.GetExtension(filechooserwidget2.Filename);
            if (ext != ".txt")
            {
                textview3.Buffer.Text += "File 2 is not .txt\n";
                return;
            }
            string[] lines = System.IO.File.ReadAllLines(filechooserwidget2.Filename);

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

    protected void Read1(object sender, EventArgs e)
    {
        try
        {
            string text = (textview1.Buffer.Text);
            textview3.Buffer.Text += text[0];
            textview3.Buffer.Text += text[1];
            textview3.Buffer.Text += text[2];
        } catch
        {

        }
    }
}
