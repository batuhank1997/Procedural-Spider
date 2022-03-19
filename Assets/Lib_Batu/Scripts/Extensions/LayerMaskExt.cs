using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
	public static class LayerMaskExt
	{
		public static bool MaskContains(this LayerMask mask, int layerNumber)
		{
			return mask == (mask | (1 << layerNumber));
		}
	}
}
