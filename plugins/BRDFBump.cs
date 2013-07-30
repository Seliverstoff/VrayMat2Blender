using System;

namespace VrayMat2Blender
{
	public class BRDFBump
	{
		public BRDFBump ()
		{
		}
	}
}

/*

Parameters for plugin 'BRDFBump'
  base_brdf: plugin, Base BRDF
  bump_tex_color: acolor texture, Bump texture
  bump_tex_float: float texture, Bump texture
  bump_tex_mult: float = 1, Bump amount
  bump_tex_mult_tex: float texture, Bump amount texture
  bump_tex: plugin, Bump texture; this is deprecated, use bump_tex_color or bump_tex_float
  bump_shadows: bool = false, true to offset the surface shading point, in addition to the normal
  map_type: integer = 0, The type of the map (0 - from regular texture output, 1 - normal map in tangent space, 2 - normal map in object space, 3 - normal map in camera space, 4 - normal map in world space, 5 - from texture bump output, 6 - explicit normal)
  normal_uvwgen: plugin, The uvw generator for the normal map texture when map_type is 1.
  maya_compatible: bool = false, When this is true the BRDFBump will try to match the Maya bump/normal mapping
  compute_bump_for_shadows: bool = true, true to compute bump mapping for shadow rays in case the material is transparent; false to skip the bump map for shadow rays (faster rendering)
  bump_delta_scale: float = 1, Scale for sampling the bitmap when map_type is 0. Normally this is tied to the ray differentials, but can be changed if necessary.


*/