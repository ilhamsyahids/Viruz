
// This file has been generated by the GUI designer. Do not modify.
namespace Viruz
{
	public partial class Window
	{
		private global::Gtk.Image image1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Viruz.Window
			this.Name = "Viruz.Window";
			this.Title = global::Mono.Unix.Catalog.GetString("Window");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Viruz.Window.Gtk.Container+ContainerChild
			this.image1 = new global::Gtk.Image();
			this.image1.Name = "image1";
			this.Add(this.image1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}