
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction1;

	private global::Gtk.Action ExitAction1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.VBox vbox4;

	private global::Gtk.HBox hbox3;

	private global::Gtk.VBox vbox6;

	private global::Gtk.FileChooserWidget filechooserwidget1;

	private global::Gtk.Button CheckFile1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow2;

	private global::Gtk.TextView textview1;

	private global::Gtk.VBox vbox10;

	private global::Gtk.Button btnRead1;

	private global::Gtk.VBox vbox8;

	private global::Gtk.FileChooserWidget filechooserwidget2;

	private global::Gtk.Button CheckFile2;

	private global::Gtk.ScrolledWindow GtkScrolledWindow5;

	private global::Gtk.TextView textview2;

	private global::Gtk.VBox vbox11;

	private global::Gtk.Button btnRead2;

	private global::Gtk.VBox vbox15;

	private global::Gtk.Label label1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow6;

	private global::Gtk.TextView textview3;

	private global::Gtk.VBox vbox3;

	private global::Gtk.Image image1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label2;

	private global::Gtk.Entry entry1;

	private global::Gtk.Button button1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction1 = new global::Gtk.Action("FileAction1", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction1, null);
		this.ExitAction1 = new global::Gtk.Action("ExitAction1", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
		this.ExitAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction1, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar1\'><menu name=\'FileAction1\' action=\'FileAction1\'><menui" +
				"tem name=\'ExitAction1\' action=\'ExitAction1\'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.filechooserwidget1 = new global::Gtk.FileChooserWidget(((global::Gtk.FileChooserAction)(0)));
		this.filechooserwidget1.WidthRequest = 400;
		this.filechooserwidget1.HeightRequest = 350;
		this.filechooserwidget1.Name = "filechooserwidget1";
		this.vbox6.Add(this.filechooserwidget1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.filechooserwidget1]));
		w3.Position = 0;
		// Container child vbox6.Gtk.Box+BoxChild
		this.CheckFile1 = new global::Gtk.Button();
		this.CheckFile1.CanFocus = true;
		this.CheckFile1.Name = "CheckFile1";
		this.CheckFile1.UseUnderline = true;
		this.CheckFile1.Label = global::Mono.Unix.Catalog.GetString("Check File .txt 1");
		this.vbox6.Add(this.CheckFile1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.CheckFile1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.HeightRequest = 200;
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow2.Add(this.textview1);
		this.vbox6.Add(this.GtkScrolledWindow2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GtkScrolledWindow2]));
		w6.Position = 2;
		// Container child vbox6.Gtk.Box+BoxChild
		this.vbox10 = new global::Gtk.VBox();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.btnRead1 = new global::Gtk.Button();
		this.btnRead1.CanFocus = true;
		this.btnRead1.Name = "btnRead1";
		this.btnRead1.UseUnderline = true;
		this.btnRead1.Label = global::Mono.Unix.Catalog.GetString("Read File 1");
		this.vbox10.Add(this.btnRead1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.btnRead1]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox6.Add(this.vbox10);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.vbox10]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox3.Add(this.vbox6);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox6]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.filechooserwidget2 = new global::Gtk.FileChooserWidget(((global::Gtk.FileChooserAction)(0)));
		this.filechooserwidget2.WidthRequest = 400;
		this.filechooserwidget2.HeightRequest = 350;
		this.filechooserwidget2.Name = "filechooserwidget2";
		this.vbox8.Add(this.filechooserwidget2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.filechooserwidget2]));
		w10.Position = 0;
		// Container child vbox8.Gtk.Box+BoxChild
		this.CheckFile2 = new global::Gtk.Button();
		this.CheckFile2.CanFocus = true;
		this.CheckFile2.Name = "CheckFile2";
		this.CheckFile2.UseUnderline = true;
		this.CheckFile2.Label = global::Mono.Unix.Catalog.GetString("Check File .txt 2");
		this.vbox8.Add(this.CheckFile2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.CheckFile2]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.GtkScrolledWindow5 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow5.Name = "GtkScrolledWindow5";
		this.GtkScrolledWindow5.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow5.Gtk.Container+ContainerChild
		this.textview2 = new global::Gtk.TextView();
		this.textview2.HeightRequest = 200;
		this.textview2.CanFocus = true;
		this.textview2.Name = "textview2";
		this.GtkScrolledWindow5.Add(this.textview2);
		this.vbox8.Add(this.GtkScrolledWindow5);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.GtkScrolledWindow5]));
		w13.Position = 2;
		// Container child vbox8.Gtk.Box+BoxChild
		this.vbox11 = new global::Gtk.VBox();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.btnRead2 = new global::Gtk.Button();
		this.btnRead2.CanFocus = true;
		this.btnRead2.Name = "btnRead2";
		this.btnRead2.UseUnderline = true;
		this.btnRead2.Label = global::Mono.Unix.Catalog.GetString("Read File 2");
		this.vbox11.Add(this.btnRead2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.btnRead2]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		this.vbox8.Add(this.vbox11);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.vbox11]));
		w15.Position = 3;
		w15.Expand = false;
		w15.Fill = false;
		this.hbox3.Add(this.vbox8);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox8]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox15 = new global::Gtk.VBox();
		this.vbox15.Name = "vbox15";
		this.vbox15.Spacing = 6;
		// Container child vbox15.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Logs:");
		this.vbox15.Add(this.label1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.label1]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox15.Gtk.Box+BoxChild
		this.GtkScrolledWindow6 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow6.Name = "GtkScrolledWindow6";
		this.GtkScrolledWindow6.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow6.Gtk.Container+ContainerChild
		this.textview3 = new global::Gtk.TextView();
		this.textview3.WidthRequest = 400;
		this.textview3.CanFocus = true;
		this.textview3.Name = "textview3";
		this.textview3.Editable = false;
		this.GtkScrolledWindow6.Add(this.textview3);
		this.vbox15.Add(this.GtkScrolledWindow6);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.GtkScrolledWindow6]));
		w19.Position = 1;
		// Container child vbox15.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.image1 = new global::Gtk.Image();
		this.image1.Name = "image1";
		this.vbox3.Add(this.image1);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.image1]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		this.vbox15.Add(this.vbox3);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.vbox3]));
		w21.Position = 2;
		w21.Expand = false;
		w21.Fill = false;
		this.hbox3.Add(this.vbox15);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox15]));
		w22.Position = 2;
		w22.Expand = false;
		w22.Fill = false;
		this.vbox4.Add(this.hbox3);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
		w23.Position = 0;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Batas Waktu :");
		this.hbox1.Add(this.label2);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.hbox1.Add(this.entry1);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry1]));
		w25.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Solve");
		this.hbox1.Add(this.button1);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button1]));
		w26.Position = 2;
		w26.Expand = false;
		w26.Fill = false;
		this.vbox4.Add(this.hbox1);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.vbox1.Add(this.vbox4);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox4]));
		w28.Position = 1;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 800;// 1225;
		this.DefaultHeight = 600;// 932;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.ExitAction1.Activated += new global::System.EventHandler(this.exit);
		this.CheckFile1.Pressed += new global::System.EventHandler(this.Check1);
		this.btnRead1.Pressed += new global::System.EventHandler(this.Read1);
		this.CheckFile2.Pressed += new global::System.EventHandler(this.Check2);
		this.btnRead2.Pressed += new global::System.EventHandler(this.Read2);
		this.button1.Pressed += new global::System.EventHandler(this.Solve);
	}
}
