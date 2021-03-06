
// This file has been generated by the GUI designer. Do not modify.
namespace VrayMat2Blender
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action FileAction;
		private global::Gtk.Action MenuOpen;
		private global::Gtk.Action HelpAction;
		private global::Gtk.Action ToolBtnOpen;
		private global::Gtk.Action convertAction;
		private global::Gtk.Action saveAction;
		private global::Gtk.Action helpAction;
		private global::Gtk.Action aboutAction;
		private global::Gtk.Action OpenMatAction;
		private global::Gtk.Action SettingsAction;
		private global::Gtk.ToggleAction CheckedUpTheCorrectPathsAction;
		private global::Gtk.Action copyAction;
		private global::Gtk.Action clearAction;
		private global::Gtk.Action executeAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.Toolbar toolbar2;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView tree;
		private global::Gtk.VPaned vpaned1;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textVrscene;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.TextView textScript;
		private global::Gtk.Toolbar toolbar3;
		private global::Gtk.Statusbar statusbar1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget VrayMat2Blender.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.MenuOpen = new global::Gtk.Action ("MenuOpen", global::Mono.Unix.Catalog.GetString ("Open..."), null, "gtk-open");
			this.MenuOpen.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open...");
			w1.Add (this.MenuOpen, null);
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction, null);
			this.ToolBtnOpen = new global::Gtk.Action ("ToolBtnOpen", null, null, "gtk-open");
			w1.Add (this.ToolBtnOpen, null);
			this.convertAction = new global::Gtk.Action ("convertAction", null, null, "gtk-convert");
			this.convertAction.Sensitive = false;
			w1.Add (this.convertAction, null);
			this.saveAction = new global::Gtk.Action ("saveAction", null, null, "gtk-save");
			this.saveAction.Sensitive = false;
			w1.Add (this.saveAction, null);
			this.helpAction = new global::Gtk.Action ("helpAction", global::Mono.Unix.Catalog.GetString ("_Справка"), null, "gtk-help");
			this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Справка");
			w1.Add (this.helpAction, null);
			this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("_О программе"), null, "gtk-about");
			this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_О программе");
			w1.Add (this.aboutAction, null);
			this.OpenMatAction = new global::Gtk.Action ("OpenMatAction", global::Mono.Unix.Catalog.GetString ("OpenMat"), null, null);
			this.OpenMatAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("OpenMat");
			w1.Add (this.OpenMatAction, null);
			this.SettingsAction = new global::Gtk.Action ("SettingsAction", global::Mono.Unix.Catalog.GetString ("Settings"), null, null);
			this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Settings");
			w1.Add (this.SettingsAction, null);
			this.CheckedUpTheCorrectPathsAction = new global::Gtk.ToggleAction ("CheckedUpTheCorrectPathsAction", global::Mono.Unix.Catalog.GetString ("Checked up the correct paths"), null, null);
			this.CheckedUpTheCorrectPathsAction.Active = true;
			this.CheckedUpTheCorrectPathsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Checked up the correct paths");
			w1.Add (this.CheckedUpTheCorrectPathsAction, null);
			this.copyAction = new global::Gtk.Action ("copyAction", null, null, "gtk-copy");
			this.copyAction.Sensitive = false;
			w1.Add (this.copyAction, null);
			this.clearAction = new global::Gtk.Action ("clearAction", null, null, "gtk-clear");
			this.clearAction.Sensitive = false;
			w1.Add (this.clearAction, null);
			this.executeAction = new global::Gtk.Action ("executeAction", null, null, "gtk-execute");
			this.executeAction.Sensitive = false;
			w1.Add (this.executeAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "VrayMat2Blender.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("VrayMat2Blender");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-color-picker", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child VrayMat2Blender.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='MenuOpen' action='MenuOpen'/><menu name='SettingsAction' action='SettingsAction'><menuitem name='CheckedUpTheCorrectPathsAction' action='CheckedUpTheCorrectPathsAction'/></menu></menu><menu name='HelpAction' action='HelpAction'><menuitem name='helpAction' action='helpAction'/><menuitem name='aboutAction' action='aboutAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name=\'toolbar2\'><toolitem name=\'ToolBtnOpen\' action=\'ToolBtnOpen\'/><" +
				"toolitem name=\'convertAction\' action=\'convertAction\'/></toolbar></ui>");
			this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar2")));
			this.toolbar2.Name = "toolbar2";
			this.toolbar2.ShowArrow = false;
			this.vbox1.Add (this.toolbar2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar2]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 372;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.tree = new global::Gtk.TreeView ();
			this.tree.CanFocus = true;
			this.tree.Name = "tree";
			this.GtkScrolledWindow1.Add (this.tree);
			this.hpaned1.Add (this.GtkScrolledWindow1);
			global::Gtk.Paned.PanedChild w5 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.GtkScrolledWindow1]));
			w5.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.CanFocus = true;
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 218;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			this.vbox5.BorderWidth = ((uint)(9));
			// Container child vbox5.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Sorce *.vrscene  (read only)");
			this.vbox5.Add (this.label2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textVrscene = new global::Gtk.TextView ();
			this.textVrscene.CanFocus = true;
			this.textVrscene.Name = "textVrscene";
			this.textVrscene.Editable = false;
			this.GtkScrolledWindow.Add (this.textVrscene);
			this.vbox5.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow]));
			w8.Position = 1;
			this.vpaned1.Add (this.vbox5);
			global::Gtk.Paned.PanedChild w9 = ((global::Gtk.Paned.PanedChild)(this.vpaned1 [this.vbox5]));
			w9.Resize = false;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.HeightRequest = 200;
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(9));
			// Container child vbox4.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Result out (Python script for Blender)");
			this.vbox4.Add (this.label1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.textScript = new global::Gtk.TextView ();
			this.textScript.CanFocus = true;
			this.textScript.Name = "textScript";
			this.GtkScrolledWindow2.Add (this.textScript);
			this.vbox4.Add (this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow2]));
			w12.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><toolbar name='toolbar3'><toolitem name='saveAction' action='saveAction'/><toolitem name='copyAction' action='copyAction'/><toolitem name='clearAction' action='clearAction'/><separator/><toolitem name='executeAction' action='executeAction'/></toolbar></ui>");
			this.toolbar3 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar3")));
			this.toolbar3.Name = "toolbar3";
			this.toolbar3.ShowArrow = false;
			this.vbox4.Add (this.toolbar3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.toolbar3]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.vpaned1.Add (this.vbox4);
			this.hpaned1.Add (this.vpaned1);
			this.vbox1.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hpaned1]));
			w16.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.statusbar1 = new global::Gtk.Statusbar ();
			this.statusbar1.Name = "statusbar1";
			this.statusbar1.Spacing = 6;
			this.vbox1.Add (this.statusbar1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 855;
			this.DefaultHeight = 582;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.MenuOpen.Activated += new global::System.EventHandler (this.OnMenuOpenActivated);
			this.ToolBtnOpen.Activated += new global::System.EventHandler (this.OnToolBtnOpenActivated);
			this.convertAction.Activated += new global::System.EventHandler (this.OnConvertActionActivated);
			this.helpAction.Activated += new global::System.EventHandler (this.OnHelpActionActivated);
			this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
			this.copyAction.Activated += new global::System.EventHandler (this.OnCopyActionActivated);
			this.clearAction.Activated += new global::System.EventHandler (this.OnClearActionActivated);
		}
	}
}
