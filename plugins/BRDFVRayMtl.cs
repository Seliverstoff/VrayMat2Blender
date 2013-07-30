using System;
using System.Collections.Generic;
using Vray;

namespace VrayMat2Blender
{
	public class BRDFVRayMtl
	{
		public VrayMtlType MtlType;
		public String MtlName;
		public Object test;
		public int Interpolation;
		public String Name = "BRDFVRayMtl";

		public BRDFVRayMtl ()
		{
			//VrayMtlParam tsts = new VrayMtlParam ();
			//Console.WriteLine (tsts.diffuse.GetType());
		}

		private void SetDefolt(){
			//VrayMtlParam Param = new VrayMtlParam ();
			//Param.diffuse = new FloatVectorProperty (0.75F, 0.75F, 0.75F);
		}

		public struct VrayMtlParam{
			//public FloatVectorProperty diffuse;
			//public FloatTexture diffuse;
		}
	}
}

/*

Parameters for plugin 'BRDFVRayMtl'
  opacity: float texture = 1, The opacity of the material
  diffuse: acolor texture = AColor(0.5, 0.5, 0.5, 1), The diffuse color of the material
  roughness: float texture = 0, The roughness of the diffuse part of the material
  brdf_type: integer = 1, The BRDF type (0 - Phong, 1 - Blinn, 2 - Ward)
  reflect: acolor texture = AColor(0, 0, 0, 1), The reflection color of the material
  reflect_glossiness: float texture = 1, The glossiness of the reflections
  hilight_glossiness: float texture = 1, The glossiness of the hilights
  hilight_glossiness_lock: bool = true, true to use the reflection glossiness also for hilights (hilight_glossiness is ignored)
  fresnel: bool = false, true to enable fresnel reflections
  fresnel_ior: float texture = 1.6, The ior for calculating the Fresnel term
  fresnel_ior_lock: bool = true, true to use the refraction ior also for the Fresnel term (fresnel_ior is ignored)
  reflect_subdivs: integer = 8, Subdivs for glossy reflectons
  reflect_trace: bool = true, true to trace reflections and false to only do hilights
  reflect_depth: integer = 5, The maximum depth for reflections
  reflect_exit_color: color = Color(0, 0, 0), The color to use when the maximum depth is reached
  hilight_soften: float = 0, How much to soften hilights and reflections at grazing light angles
  reflect_dim_distance: float = 1e+018, How much to dim reflection as length of rays increases
  reflect_dim_distance_on: bool = false, True to enable dim distance
  reflect_dim_distance_falloff: float = 0, Fall off for the dim distance
  reflect_affect_alpha: integer = 0, Determines how reflections affect the alpha channel (0 - opaque alpha; 1 - alpha is taken from refractions; 2 - all channels are propagated
  anisotropy: float texture = 0, The anisotropy for glossy reflections, from -1 to 1 (0.0 is isotropic reflections)
  anisotropy_rotation: float texture = 0, The rotation of the anisotropy axes, from 0.0 to 1.0
  anisotropy_derivation: integer = 0, What method to use for deriving anisotropy axes (0 - local object axis; 1 - a specified uvw generator)
  anisotropy_axis: integer = 2, Which local object axis to use when anisotropy_derivation is 0
  anisotropy_uvwgen: plugin, The uvw generator to use for anisotropy when anisotropy_derivation is 1
  refract: acolor texture = AColor(0, 0, 0, 1), The refraction color of the material
  refract_ior: float texture = 1.6, The IOR for refractions
  refract_glossiness: float texture = 1, Glossiness for refractions
  refract_subdivs: integer = 8, Subdivs for glossy refractions
  refract_trace: bool = true, 1 to trace refractions; 0 to disable them
  refract_depth: integer = 5, The maximum depth for refractions
  refract_exit_color: color = Color(0, 0, 0), The color to use when maximum depth is reached when refract_exit_color_on is true
  refract_exit_color_on: bool = false, If false, when the maximum refraction depth is reached, the material is assumed transparent, instead of terminating the ray
  refract_affect_alpha: integer = 0, Determines how refractions affect the alpha channel (0 - opaque alpha; 1 - alpha is taken from refractions; 2 - all channels are propagated
  refract_affect_shadows: bool = false, true to enable the refraction to affect the shadows cast by the material (as transparent shadows)
  dispersion_on: bool = false, true to enable dispersion
  dispersion: float = 50, abbe value
  fog_color: color = Color(1, 1, 1), The absorption (fog) color
  fog_mult: float = 1, Multiplier for the absorption
  fog_bias: float = 0, Bias for the absorption
  fog_unit_scale_on: bool = true, Enable unit scale multiplication, when calculating absorption
  translucency: integer = 0, Translucency mode (0 - none)
  translucency_color: acolor texture = AColor(1, 1, 1, 1), Filter color for the translucency effect
  translucency_light_mult: float = 1, A multiplier for the calculated lighting for the translucency effect
  translucency_scatter_dir: float = 0.5, Scatter direction (0.0f is backward, 1.0f is forward)
  translucency_scatter_coeff: float = 0, Scattering cone (0.0f - no scattering, 1.0f - full scattering
  translucency_thickness: float = 1e+018, Maximum distance to trace inside the object
  option_double_sided: bool = true, true if the material is double-sided
  option_reflect_on_back: bool = false, true to compute reflections for back sides of objects
  option_glossy_rays_as_gi: integer = 1, Specifies when to treat GI rays as glossy rays (0 - never; 1 - only for rays that are already GI rays; 2 - always
  option_cutoff: float = 0.001, Specifies a cutoff threshold for tracing reflections/refractions
  option_use_irradiance_map: bool = true, false to perform local brute-force GI calculatons and true to use the current GI engine
  option_energy_mode: integer = 0, Energy preservation mode for reflections and refractions (0 - color, 1 - monochrome)
  option_fix_dark_edges: integer = 1, true to fix dark edges for glossy reflections with low samples; only set this to false for compatibility with older versions
  environment_override: acolor texture, Environment override texture
  environment_priority: integer = 0, Environment override priority (used when several materials override it along a ray path)

 */