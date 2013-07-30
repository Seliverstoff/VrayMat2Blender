using System;
using Vray;
using System.Collections.Generic;

namespace VrayMat2Blender
{
	public class BRDFDiffuse
	{
		public String Name = "BRDFDiffuse";
		public Dictionary<string, string> map = new Dictionary<string, string>();
		public List<SinglParam> Param = new List<SinglParam>();
		
		public BRDFDiffuse ()
		{
			Param.Add (new SinglParam("name","blender_name","type","defolt","line"));
		}
		
		private Dictionary<string, System.Object> GetParam(Dictionary<string, System.Object> mtlParam){

			return mtlParam;
		}

		public string GenOut(){
			String txt = String.Empty;

			return txt;
		}
	}
}


/*

Parameters for plugin 'BRDFDiffuse'
  color: color = Color(1, 1, 1)
  color_tex: acolor texture
  color_tex_mult: float = 1
  transparency: color = Color(0, 0, 0)
  transparency_tex: acolor texture
  transparency_tex_mult: float = 1
  roughness: float texture
  use_irradiance_map: bool = true

*/