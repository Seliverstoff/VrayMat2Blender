using System;

namespace Vray
{
	/*
	// support types
	public enum VrayMtlType
	{
		BRDFVRayMtl,
		BRDFSSS2Complex,
		BRDFLight,
		BRDFCarPaint,
		BRDFHair3,
		BRDFLayered,
		BitmapBuffer,
		UVWGenChannel,
		TexBitmap,
		BRDFDiffuse,
		BRDFBump,
		MtlSingleBRDF,
		BRDFGlass
	}
*/
	public enum VrayMtlType
	{

		TexParticleSampler,
		TexParticleDiffuse,
		TexEdges,
		TexSky,
		UVWGenProjection,
		UVWGenPlanarWorld,
		UVWGenObject,
		UVWGenExplicit,
		UVWGenEnvironment,
		UVWGenChannel,
		TexWood,
		TexWater,
		TexUVW,
		UVWGenSwitch,
		TexSwitchInt,
		TexSwitchTransform,
		TexSwitchMatrix,
		TexSwitchFloat,
		TexSwitch,
		TexSnow,
		TexAColorOp,
		TexFloatOp,
		TexVectorOp,
		TexSampler,
		TexRock,
		TexRemap,
		TexRamp,
		TexPtex,
		TexNoise,
		TexFloat,
		TexMultiFloat,
		TexMulti,
		TexSurfaceLuminance,
		ParticleTex,
		TexUserScalar,
		TexUserColor,
		TexNoiseMaya,
		TexTemperatureToColor,
		MtlStreakFade,
		TexVertexColorDirect,
		TexMayaConversion,
		TexStencil,
		TexColorAndAlpha,
		TexLuminance,
		TexMeshVertexColorChannel,
		TexMeshVertexColorWithDefault,
		TexMeshVertexColor,
		TexMayaContrast,
		TexUVWGenToTexture,
		TexCondition2,
		TransformToTex,
		FloatToTex,
		TexPlusMinusAverage,
		TexDistanceBetween,
		TexVectorToColor,
		TexVectorProduct,
		TexSetRange,
		TexHSVToRGB,
		TexRGBToHSV,
		MayaProjectionTex,
		UVWGenMayaPlace2dTexture,
		MayaMtlMatte,
		MayaGamma,
		MayaMultiplyDivide,
		TexHairSampler,
		TexVRayFurSampler,
		TexMayaHairTransparency,
		TexMayaHairIncandescence,
		TexMayaHairColor,
		TexMayaFluidTransformed,
		TexMayaFluidCombined,
		TexMayaFluidProcedural,
		TexMayaFluid,
		TexCompMax,
		TexColorToFloat,
		TexFloatToColor,
		TexRGBMultiplyMax,
		TexRGBTintMax,
		TexCombineColorLightMtl,
		TexCombineColor,
		TexCombineFloat,
		TexBezierCurve,
		TexNormalMapFlip,
		TexOutput,
		UVWGenObjectBBox,
		MtlObjBBox,
		TexGradient,
		TexFalloff,
		TexNoiseMax,
		TexMaskMax,
		TexMix,
		TexMarbleMax,
		TexSwirl,
		TexTiles,
		TexSpeckle,
		TexSmoke,
		TexStucco,
		TexSplat,
		TexLayeredMax,
		TexBerconTile,
		TexBerconWood,
		TexBerconGrad,
		TexGradRamp,
		ColorCorrect,
		ColorTextureToMono,
		ColorCorrection,
		TexMarble,
		TexLeather,
		TexLayered,
		TexInvert,
		TexGrid,
		TexGranite,
		TexFresnel,
		TexDirt,
		TexCloth,
		TexCondition,
		TexClamp,
		TexChecker,
		TexCellular,
		TexBulge,
		TexBlendBumpNormal,
		TexBlend,
		TexBitmap,
		TexAColor,
		MtlWrapperMaya,
		MtlWrapper,
		MtlSingleBRDF,
		MtlRoundEdges,
		MtlRenderStats,
		MtlMayaRamp,
		MtlOverride,
		MtlMulti,
		MtlMaterialID,
		MtlLayeredBRDF,
		MtlDoubleSided,
		MtlDiffuse,
		MtlBump,
		Mtl2Sided,
		RawBitmapBuffer,
		BitmapBuffer,
		BRDFVRayMtl,
		BRDFSSS2Complex,
		BRDFSSS2,
		BRDFSSS,
		BRDFPhong,
		BRDFMirror,
		BRDFLight,
		BRDFLayered,
		BRDFHair3,
		BRDFHair2,
		BRDFHair,
		BRDFGlassGlossy,
		BRDFGlass,
		BRDFDiffuse_forSSS,
		BRDFDiffuse,
		BRDFFlakes,
		BRDFCarPaint,
		BRDFBump,
		BRDFCookTorrance,
		BRDFWard,
		BRDFBlinn
	}

	public class SinglParam
	{
		public string Name;
		public string BlenderName;
		public string ParamType;
		public string ParamVal;
		public string Defolt;

		public SinglParam (string _name, string _blender_name, string _type, string _defolt, string _line)
		{
			Name = _name;
			BlenderName = _blender_name;
			ParamType = _type;
			Defolt = _defolt;

			switch (_type) {
			case "color": 
				Color tColor = new Color ();
				ParamVal = tColor.Calc (_line);
				break;
			case "acolor": 
				AColor tAColor = new AColor ();
				ParamVal = tAColor.Calc (_line);
				break;
			case "acolor texture": 
				AColorTexture tAColorTexture = new AColorTexture ();
				ParamVal = tAColorTexture.Calc (_line);
				break;
			case "float texture": 
				FloatTexture tFloatTexture = new FloatTexture ();
				ParamVal = tFloatTexture.Calc (_line);
				break;
			case "float": 
				Float tFloat = new Float ();
				ParamVal = tFloat.Calc (_line);
				break;
			case "double": 
				Double tDouble = new Double ();
				ParamVal = tDouble.Calc (_line);
				break;
			case "integer": 
				Integer tInteger = new Integer ();
				ParamVal = tInteger.Calc (_line);
				break;
			case "bool": 
				Bool tBool = new Bool ();
				ParamVal = tBool.Calc (_line);
				break;
			}
		}
	}

	public class Color
	{
		public Color ()
		{

		}

		public string Calc (string str)
		{
			string Val;
			char[] div = new char[] { ',', '(', ')' };
			string[] tmpTex = str.Split (div);
			Val = "(" + tmpTex [1] + "," + tmpTex [2] + "," + tmpTex [3] + ")";

			return Val;
		}
	}

	public class AColor
	{
		public AColor ()
		{
		
		}

		public string Calc (string ins)
		{
			string Val;
			char[] div = new char[] { ',', '(', ')' };
			string[] tmpTex = ins.Split (div);
			Val = "(" + tmpTex [1] + "," + tmpTex [2] + "," + tmpTex [3] + "," + tmpTex [4] + ")";

			return Val;
		}
	}

	public class AColorTexture
	{
		public AColorTexture ()
		{
		
		}

		public string Calc (string ins)
		{
			string Val;
			if (ins.Equals ("AColor")) {
				char[] div = new char[] { ',', '(', ')' };
				string[] tmpTex = ins.Split (div);
				Val = "(" + tmpTex [1] + "," + tmpTex [2] + "," + tmpTex [3] + "," + tmpTex [4] + ")";
			} else {
				Val = ins;
			}

			return Val;
		}
	}

	public class FloatTexture
	{
		public FloatTexture ()
		{

		}

		public string Calc (string ins)
		{

			string Val;

			//if(ins.Equals("AColor")){
			//	char[] div = new char[] {',','(',')'};
			//	string[] tmpTex = ins.Split(div);
			//	Val = "("+tmpTex[1]+","+tmpTex[2]+","+tmpTex[3]+","+tmpTex[4]+")";
			//}else{
			Val = ins;
			//}

			return Val;
		}
	}

	public class Float
	{
		public Float ()
		{

		}

		public string Calc (string ins)
		{
			string Val;
			/*
			char[] div = new char[] {',','(',')'};
			string[] tmpTex = ins.Split(div);
			Val = "("+tmpTex[1]+","+tmpTex[2]+","+tmpTex[3]+","+tmpTex[4]+")";
			*/
			Val = ins;

			return Val;
		}
	}

	public class Double
	{
		public Double ()
		{

		}

		public string Calc (string ins)
		{
			string Val;
			/*
			char[] div = new char[] {',','(',')'};
			string[] tmpTex = ins.Split(div);
			Val = "("+tmpTex[1]+","+tmpTex[2]+","+tmpTex[3]+","+tmpTex[4]+")";
			*/
			Val = ins;

			return Val;
		}
	}

	public class Integer
	{
		public Integer ()
		{

		}

		public string Calc (string ins)
		{
			string Val;
			/*
			char[] div = new char[] {',','(',')'};
			string[] tmpTex = ins.Split(div);
			Val = "("+tmpTex[1]+","+tmpTex[2]+","+tmpTex[3]+","+tmpTex[4]+")";
			*/
			Val = ins;

			return Val;
		}
	}

	public class Bool
	{
		public Bool ()
		{

		}

		public string Calc (string ins)
		{
			string Val;
			/*
			char[] div = new char[] {',','(',')'};
			string[] tmpTex = ins.Split(div);
			Val = "("+tmpTex[1]+","+tmpTex[2]+","+tmpTex[3]+","+tmpTex[4]+")";
			*/
			Val = ins;

			return Val;
		}
	}
}

