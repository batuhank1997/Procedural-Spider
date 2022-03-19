using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
	public static class IntExt
	{
		public static int WithRandomSign(this int value, float negativeProbability = 0.5f)
		{
			return Random.value < negativeProbability ? -value : value;
		}
	}
}

