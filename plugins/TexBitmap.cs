using System;

namespace VrayMat2Blender
{
	public class TexBitmap
	{
		public TexBitmap ()
		{
		}
	}
}


/*

Parameters for plugin 'TexBitmap'
  compatibility_with: integer = 0, This is used to differentiate between textures exported from different applications. The value means : 0 - 3ds Max (this is also the default), 1 - Maya, ...
  alpha_from_intensity: bool = false, If true, the resulting alpha is the color intensity; otherwise the alpha is taken from the bitmap alpha
  invert: bool = false, If true, the resulting texture color will be inverted
  invert_alpha: bool = true, If true and invert is on, the resulting texture alpha will be inverted too. If false, just the color will be inverted
  color_mult: acolor texture = AColor(1, 1, 1, 1), A multiplier for the texture color
  color_offset: acolor texture = AColor(0, 0, 0, 0), An additional offset for the texture color
  alpha_mult: float texture = 1, A multiplier for the texture alpha
  alpha_offset: float texture = 0, An additional offset for the texture alpha
  nouvw_color: acolor texture = AColor(0.5, 0.5, 0.5, 1), The color when there are no valid uvw coordinates
  color: output acolor texture, The resulting color
  out_transparency: output acolor texture, The resulting transparency
  out_alpha: output float texture, The resulting alpha
  out_intensity: output float texture, The resulting intensity
  tile: integer = 1, 0: not tiling; 1: tile in UV; 2: tile in U; 3: tile in V
  uvwgen: plugin, The uvw generator for the texture
  placement_type: integer = 0, The way the valid portion of the texture is applied: 0 - the whole texture is valid, 1 - crop, 2 -place
  u: float = 0, U coordinate of the valid texture sector
  v: float = 0, V coordinate of the valid texture sector
  w: float = 1, Width of the valid texture sector
  h: float = 1, Height of the valid texture sector
  jitter: float = 0, Amount of random placement variation
  tile_u: integer = 0, If true there is horizontal tiling
  tile_v: integer = 0, If true there is vertical tiling
  uv_noise_on: integer = 0, If true the noise is enabled
  uv_noise_animate: integer = 0, If true the noise is animated
  uv_noise_amount: float = 1, UV noise amount
  uv_noise_levels: float = 1, UV noise iterations
  uv_noise_size: float = 1, UV noise size
  un_noise_phase: float = 0, UV noise phase
  bitmap: plugin

*/