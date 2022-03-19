using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
	public static class FloatExt
	{
        public static float LinearRemap(this float value, float valueRangeMin, float valueRangeMax, float newRangeMin, float newRangeMax)
        {
            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }
    }
}

