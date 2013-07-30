using System;

namespace VrayMat2Blender
{
	public class BitmapBuffer
	{
		public BitmapBuffer ()
		{
		}
	}
}

/*

Parameters for plugin 'BitmapBuffer'
  filter_type: integer = 1, 0 - no filtering; 1 - mip-map filtering; 2 - summed area table filtering
  filter_blur: float = 1
  color_space: integer = 1, 0 - linear, 1 - gamma corrected, 2 - sRGB
  gamma: float = 1
  maya_compatible: bool = false
  allow_negative_colors: bool = false, if false negative colors will be clamped
  interpolation: integer = 0, Interpolation method for the mip-map filtering (0 - bilinear, 1 - bicubic)
  file: string = "", The file name; can contain <UDIM> or <UVTILE> tags for Mari or Mudbox tiles respectively,or $nU and $nV for explicit tiles; lower-case tags consider the tiles as starting from 0 whereas upper-case tags start from 1
  load_file: bool = true, if set to false, the file would not be loaded
  frame_sequence: bool = false
  frame_number: integer = 0
  frame_offset: integer = 0
  use_data_window: bool = true, true to use the data window information in e.g. OpenEXR files; otherwise false
  psd_group_name: integer, unlimited list
  psd_alpha_name: integer, unlimited list
  ifl_start_frame: integer = 0
  ifl_playback_rate: float = 1
  ifl_end_condition: integer = 0, Image file list (IFL) end condition: 0 - Loop; 1 - Ping Pong; 2 - Hold;


*/