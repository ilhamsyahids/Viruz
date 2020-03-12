using System;
namespace Viruz
{
    public partial class Window : Gtk.Window
    {
        public Window() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            var buffer = System.IO.File.ReadAllBytes("../../black.jpg");
            var pixbuf = new Gdk.Pixbuf(buffer);
            image1.Pixbuf = pixbuf;
        }
    }
}
