using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
	public static class SpriteRendererExt
	{
		public static void SetAlpha(this SpriteRenderer sprite, float alpha)
		{
			Color color = sprite.color;
			color.a = alpha;
			sprite.color = color;
		}
	}
}
