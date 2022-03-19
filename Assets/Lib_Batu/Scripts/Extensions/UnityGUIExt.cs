using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
	public static class UnityGUIExt
	{
		public static void SetAlpha(this UnityEngine.UI.Graphic graphic, float alpha)
		{
			Color color = graphic.color;
			color.a = alpha;
			graphic.color = color;
		}
	}
}
