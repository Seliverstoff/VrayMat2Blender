using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Vray;
using Gtk;

namespace VrayMat2Blender
{
	public class VrScene
	{
		public String VrDataSorce;
		public Dictionary<string, Dictionary<string, Dictionary<string, System.Object>>> VRayMtl;
		public Boolean start_func = false;
		public Boolean old_start_func = false;
		public List<string> AllDump = new List<string>();
		// support Mtl - BRDFVRayMtl, BRDFSSS2Complex, BRDFLight, BRDFCarPaint, BRDFHair3, BRDFLayered 

		public VrScene (string path)
		{
			// Запускаем чтение файла
			VRreader (path);
		}
		// публичная функция чтения файла
		public void VRreader (String path)
		{
			// Создаем переменную для строки
			String Line;

			VRayMtl = new Dictionary<string, Dictionary<string,  Dictionary<string, System.Object>>> ();

			// читаем данные
			try {
				FileStream fs = new FileStream (path, FileMode.Open);
				StreamReader sr = new StreamReader (fs, Encoding.UTF8);


				String mtl_name = "empty";
				String mtl_type = "empty";

				while (sr.EndOfStream != true) {
	
					Line = sr.ReadLine ();
					VrDataSorce = VrDataSorce + Line + "\n";

					if(searchTypes(Line)){
						Line = Line.TrimStart(' ');
						Line = Line.TrimEnd(' ');
						AllDump.Add(Line);
					}
				}

				sr.Close ();
				ReFormatting (AllDump);

				for(var i = 0; i < AllDump.Count; i++){

					AllDump[i] = AllDump[i].TrimEnd(';');

					if(AllDump[i].Contains("{"))
						start_func = true;

					if(AllDump[i].Contains("}"))
						start_func = false;

					string[] tmpLine = AllDump[i].Split(' ');

					if (GetMtlType (tmpLine[0]) && start_func) {

						mtl_name = tmpLine[1];
						mtl_type = tmpLine[0];

						Dictionary<string, Dictionary<string, object>> Mtl = new Dictionary<string, Dictionary<string, object>> ();
						Mtl.Add (mtl_type, new Dictionary<string, object> ());
						VRayMtl.Add (mtl_name, Mtl);

					}else if(tmpLine[0]!="}"){

						tmpLine = AllDump[i].Split('=');

						if(tmpLine[0]=="file"){
							tmpLine[1] = tmpLine[1].Trim('"');

							if(!File.Exists(tmpLine[1])){
								Console.WriteLine("Not File!!!! - " + tmpLine[1]);
								Pathfinding dialog = new Pathfinding(tmpLine[1]);

								ResponseType resp = (ResponseType) dialog.Run ();
								if(resp==ResponseType.Ok){
									tmpLine[1] = dialog.ResultPath;
								}
								dialog.Destroy ();
							}

						}

						VRayMtl[mtl_name][mtl_type].Add(tmpLine[0], tmpLine[1]);
					}
				}

			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}


		}

		protected Boolean GetMtlType (String str)
		{
			foreach (string val in Enum.GetNames(typeof(Vray.VrayMtlType))) {
				if (val == str)
					return true;
			}
			return false;
		}

		protected Boolean StrInArr(Array arr, String str){
			foreach(String ins in arr){
				if (ins == str)
					return true;
			}
			return false;
		}


		protected Boolean searchTypes(String str){
			char[] charLine = new char[] { ' ', '=', '"', ',', ';', '\t', '{', '}', '(', ')' };
			string[] arr = str.Split (charLine);
			Boolean tmp_func = false;
				foreach (string val in Enum.GetNames(typeof(Vray.VrayMtlType))) {
					if (val == arr[0]){
						start_func = true;
						old_start_func = true;
						tmp_func = true;
					}else{
						tmp_func = false;
					}
			}

			if(old_start_func==false){
				start_func = false;
			}

			if(str.Contains("}") && !tmp_func){
				old_start_func = false;
			}

			return start_func;
		}

		protected void OutArr(List<string> list){
			for(var i = 0; i < list.Count; i++){
				Console.WriteLine (i+" Line = "+list[i]);
			}
		}

		protected void ReFormatting(List<string> list){
			List<string> tmpList = new List<string> ();
			String tmpStr = String.Empty;

			for(var i = 0; i < list.Count; i++){

				if (list[i].Contains ("{") || list[i].Contains ("}")) {
					tmpList.Add (list[i]);
				}

				if (list[i].Contains (";") && !list[i].Contains (");")) {
					tmpList.Add (list[i]);
				}else if(!list[i].Contains ("{") && !list[i].Contains ("}")){
					tmpStr = tmpStr + list[i];
				}

				if(list[i].Contains (");")){
					tmpList.Add (tmpStr);
					tmpStr = String.Empty;
				}
			}

			AllDump = new List<string> ();
			AllDump = tmpList;
			tmpList = new List<string> ();
		}

	}
}
