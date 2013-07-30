using System;

namespace VrayMat2Blender
{
	public class BRDFGlass
	{
		public BRDFGlass ()
		{
		}
	}
}

/*

Parameters for plugin 'BRDFGlass'
  color: color = Color(1, 1, 1)
  color_tex: acolor texture
  color_tex_mult: float = 1
  transparency: color = Color(0, 0, 0)
  transparency_tex: acolor texture
  transparency_tex_mult: float = 1
  ior: float = 1.55, IOR for the glass; this is ignored if the surface has a volume shader (the volume IOR is used).
  cutoff: float = 0.01
  affect_shadows: bool = false
  affect_alpha: integer = 0, Specifies how render channels are propagated through the glass (0 - only the color channel; 1 - color and alpha; 2 - all channels
  trace_refractions: bool = true
  trace_depth: integer = -1, The maximum refraction bounces (-1 is controlled by the global options)
  exit_color_on: bool = false
  reflect_exit_color: acolor texture = AColor(0, 0, 0, 0), The color to use when the maximum depth is reached
  refract_exit_color: acolor texture = AColor(0, 0, 0, 0), The color to use when maximum depth is reached when exit_color_on is true
  volume: plugin
  ior_tex: float texture

*/