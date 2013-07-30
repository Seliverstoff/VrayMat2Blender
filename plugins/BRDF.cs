using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Vray;

namespace VrayMat2Blender
{
	public class BRDF
	{

		//public VrayMtlType MtlType { set; get; }
		public VrayMtlType MtlType;
		public String MtlName;
		//public List<Object> Properties;
		public Object test; // надо создать отдельный универсальный объект - параметр
		public int Interpolation;

		//public enum Properties
		//{

		//}

		// это работает, но хочется дефолты объявить сразу
		//FloatVectorProperty diffuse = new FloatVectorProperty(0.75F, 0.75F, 0.75F);

		public BRDF ()
		{
			VrayMtlParam tsts = new VrayMtlParam ();
			Console.WriteLine (tsts.diffuse.GetType());
			//CoOrds ttt = new CoOrds (10, 10);
			//ttt.x = 10;

			//CoOrds ttt;
			//ttt.x;
		}

		private void SetDefolt(){
			VrayMtlParam Param = new VrayMtlParam ();
			Param.diffuse = new FloatVectorProperty (0.75F, 0.75F, 0.75F);

			//Bool_Property fff;
			//fff.Vals = 1;

			//CoOrds ggg = new CoOrds (10, 10);
			//CoOrds fff;
			//fff.x;
			//BRDF.VrayMtlParam.
			//VrayMtlParam.
			//VrayMtlParam.
			//DoubleProperty.
			//Vray.BoolProperty.Value = true;
			//Vray.FloatVectorProperty.
		}


		public struct VrayMtlParam{
			//opacity
			//public FloatVectorProperty diffuse;
			public FloatVectorProperty diffuse;
			//roughness
			//brdf_type
			//reflect
			//reflect_glossiness
			/*			//hilight_glossiness
			hilight_glossiness_lock;
			fresnel;
			//fresnel_ior
			fresnel_ior_lock;
			reflect_subdivs;
			reflect_trace;
			reflect_depth;
			reflect_exit_color;
			hilight_soften;
			reflect_dim_distance;
			reflect_dim_distance_on;
			reflect_dim_distance_falloff;
			reflect_affect_alpha;
			//anisotropy
			//anisotropy_rotation
			anisotropy_derivation;
			anisotropy_axis;
			//anisotropy_uvwgen
			//refract
			//refract_ior
			dispersion_on;
			dispersion;
			//refract_glossiness
			refract_subdivs;
			refract_trace;
			refract_depth;
			refract_exit_color;
			refract_exit_color_on;
			refract_affect_alpha;
			refract_affect_shadows;
			fog_color;
			fog_mult;
			fog_bias;
			fog_unit_scale_on;
			translucency;
			//translucency_color
			translucency_light_mult;
			translucency_scatter_dir;
			translucency_scatter_coeff;
			translucency_thickness;
			option_double_sided;
			option_reflect_on_back;
			option_glossy_rays_as_gi;
			option_cutoff;
			option_use_irradiance_map;
			option_energy_mode;
			//environment_override
			environment_priority; */
		}

	}
}
