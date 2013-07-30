using System;
using System.IO;
using Gtk;

namespace VrayMat2Blender
{
	public partial class Pathfinding : Gtk.Dialog
	{
		public string ResultFile;
		public string ResultPath;

		public Pathfinding (String pth)
		{
			this.Build ();
			entry_path.Text = pth;
			String fName = System.IO.Path.GetFileName(pth);

			ResultFile = fName;

			this.Title += " - "+fName;
		}

		protected void OnBtnOpenClicked (object sender, EventArgs e)
		{
			String input = string.Empty;
			String strFileName = String.Empty;
			Gtk.FileChooserDialog dlg = new Gtk.FileChooserDialog("Choose the file to open - "+ResultFile,
			                                                      this,
			                                                      FileChooserAction.Open,
			                                                      "Cancel",ResponseType.Cancel,
			                                                      "Open",ResponseType.Accept);

			FileFilter filter = new FileFilter();
			filter.Name = "All files (*.*)";
			filter.AddPattern("*.*");
			dlg.AddFilter(filter);

			filter = new FileFilter();
			filter.Name = "PNG Images (*.png)";
			filter.AddMimeType("image/png");
			filter.AddPattern("*.png");
			dlg.AddFilter(filter);

			if (dlg.Run() == (int)ResponseType.Accept) 
			{
				System.IO.FileStream file=System.IO.File.OpenRead(dlg.Filename);
				entry_path.Text = file.Name;
				ResultPath = entry_path.Text;
				file.Close();
			}

			dlg.Destroy ();
		}
	}
}

