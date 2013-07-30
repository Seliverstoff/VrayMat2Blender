using System;

namespace VrayMat2Blender
{
	public class UVWGenChannel
	{
		public UVWGenChannel ()
		{
		}
	}
}

/*

Parameters for plugin 'UVWGenChannel'
  uvw_transform: transform, Initial transformation on the uvw coordinates, before mirror, crop etc
  uvw_transform_tex: transform texture
  tex_transform: transform, Final transformation on the resulting uvw coordinates, after mirror, crop etc
  nsamples: integer = 0, Number of uvw transform samples
  wrap_u: integer = 0, 0 - no wrapping, 1 - wrap, 2 - mirror tile
  wrap_v: integer = 0, 0 - no wrapping, 1 - wrap, 2 - mirror tile
  wrap_w: integer = 0, 0 - no wrapping, 1 - wrap, 2 - mirror tile
  crop_u: integer = 0, 1 to crop in the u-direction
  crop_v: integer = 0, 1 to crop in the v-direction
  crop_w: integer = 0, 1 to crop in the w-direction
  coverage: vector = Color(0, 0, 0), Coverage
  uvw_coords: output vector texture, The uvw coordinates for the specified channel at the current shading point
  wrap_mode: integer = 0, Wrap mode (0 - wrap on 0.5 boundary; 1 - wrap on integer boundary
  duvw_scale: float = 1, Additional scale factor for the texture derivatives
  uvw_channel: integer = 1
  uvwgen: plugin, Optional UVWGen from which the initial uvw coordinates will be taken, instead of the surface point

*/