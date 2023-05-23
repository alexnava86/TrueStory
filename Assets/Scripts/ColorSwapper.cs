using UnityEngine;
using System.Collections;

public class ColorSwapper : MonoBehaviour 
{

	private static Texture2D colorPalette;
	private static Color[] spriteColors;

	private void Start () 
	{
		InitializeColorSwapTexture();
		//SwapColor(185, new Color(0f, 0.5f, 0.5f, 1f)); //Test
	}
	public void InitializeColorSwapTexture()
	{
		Texture2D colorSwapTex = new Texture2D(256, 1, TextureFormat.RGBA32, false, false);
		colorSwapTex.filterMode = FilterMode.Point;
		
		for (int i = 0; i < colorSwapTex.width; ++i)
		{
			colorSwapTex.SetPixel(i, 0, new Color(0.0f, 0.0f, 0.0f, 0.0f));
		}	
		colorSwapTex.Apply();
		
		this.gameObject.GetComponent<SpriteRenderer>().material.SetTexture("_SwapTex", colorSwapTex);
		
		spriteColors = new Color[colorSwapTex.width];
		colorPalette = colorSwapTex;
	}

	private void SwapColor(int startColor, Color newColor)
	{
		spriteColors[startColor] = newColor;
		colorPalette.SetPixel(startColor, 0 , newColor);
		colorPalette.Apply(); //only for test, use after swapcolor loop in production
	}
}
