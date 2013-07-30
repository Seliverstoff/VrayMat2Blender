using System;
using Gtk;
using System.IO;
using System.Text;
using System.Collections.Generic;
//using System.IO.

namespace VrayMat2Blender
{
	public partial class MainWindow: Gtk.Window
	{	
		public VrScene scene;

		public MainWindow (): base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnMenuOpenActivated (object sender, EventArgs e)
		{
			OpenMat ();
		}

		protected void OnToolBtnOpenActivated (object sender, EventArgs e)
		{
			OpenMat ();
		}

		protected void OpenMat ()
		{
			Gtk.FileChooserDialog fc =
			new Gtk.FileChooserDialog ("Choose the file *.vrscene to open",
			                          this,
			                          FileChooserAction.Open,
			                          "Cancel", ResponseType.Cancel,
			                          "Open", ResponseType.Accept);


			FileFilter filter = new FileFilter ();
			filter.Name = "Vray Scene files (*.vrscene)";
			filter.AddMimeType ("text/txt");
			filter.AddPattern ("*.vrscene");
			fc.AddFilter (filter);

			filter = new FileFilter ();
			filter.Name = "All files (*.*)";
			filter.AddPattern ("*");
			fc.AddFilter (filter);

			if (fc.Run () == (int)ResponseType.Accept) {

				scene = new VrScene (fc.Filename);
				Gtk.TextBuffer buffer = textVrscene.Buffer;

				buffer.Text = scene.VrDataSorce;
				CreateTree (scene.VRayMtl);

				this.Title = "VrayMat2Blender - "+fc.Filename;
				convertAction.Sensitive = true;

			}
			//Don't forget to call Destroy() or the FileChooserDialog window won't get closed.

			fc.Destroy ();
		}

		protected void CreateTree(Dictionary<string, Dictionary<string, Dictionary<string, System.Object>>> dic){

			Gtk.TreeViewColumn artistColumn = new Gtk.TreeViewColumn ();
			artistColumn.Title = "Parametrs";

			Gtk.CellRendererText artistNameCell = new Gtk.CellRendererText ();

			artistColumn.PackStart (artistNameCell, true);

			Gtk.TreeViewColumn songColumn = new Gtk.TreeViewColumn ();
			songColumn.Title = "Value";

			Gtk.CellRendererText songTitleCell = new Gtk.CellRendererText ();
			songColumn.PackStart (songTitleCell, true);
			songTitleCell.Editable = true;

			tree.AppendColumn (artistColumn);
			tree.AppendColumn (songColumn);

			artistColumn.AddAttribute (artistNameCell, "text", 0);

			songColumn.AddAttribute (songTitleCell, "text", 1);

			Gtk.TreeStore rootListStore = new Gtk.TreeStore (typeof (string), typeof (string));

			Gtk.TreeIter iterRoot;
			Gtk.TreeIter iterMtl;

			foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, System.Object>>> pair in dic)
			{
				iterRoot = rootListStore.AppendValues (pair.Key);

				foreach (KeyValuePair<string, Dictionary<string, System.Object>> pairMtl in pair.Value){
					iterMtl = rootListStore.AppendValues (iterRoot, pairMtl.Key);
					foreach (KeyValuePair<string, System.Object> pairObj in pairMtl.Value){
						//Console.WriteLine("KEY - {0}, VAL - {1}", pairObj.Key, pairObj.Value);
						rootListStore.AppendValues (iterMtl, pairObj.Key, pairObj.Value);
					}
				}

			}

			tree.Model = rootListStore;

		}
		protected void OnConvertActionActivated (object sender, EventArgs e)
		{
			BlenderMtlCreator SciptOut = new BlenderMtlCreator ();
			Gtk.TextBuffer buffer = textScript.Buffer;
			buffer.Text = SciptOut.CreateScript (scene);

			saveAction.Sensitive = true;
			copyAction.Sensitive = true;
			clearAction.Sensitive = true;
		}

		protected void OnAboutActionActivated (object sender, EventArgs e)
		{
			About dialog = new About();
			dialog.Run ();
			dialog.Destroy ();
		}

		protected void OnHelpActionActivated (object sender, EventArgs e)
		{
			Help dialog = new Help();
			dialog.Run ();
			dialog.Destroy ();
		}

		protected void OnCopyActionActivated (object sender, EventArgs e)
		{
			Gtk.Clipboard clipboard = Gtk.Clipboard.Get(Gdk.Atom.Intern("CLIPBOARD", false));
			clipboard.Text = textScript.Buffer.Text;

			String Msg = "Copied OK!";
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, Msg);
			md.Run ();
			md.Destroy();
		}

		protected void OnClearActionActivated (object sender, EventArgs e)
		{
			textScript.Buffer.Text = String.Empty;

			saveAction.Sensitive = false;
			copyAction.Sensitive = false;
			clearAction.Sensitive = false;
		}

	}
}
