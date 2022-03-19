using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
	public static class ParticleSystemExt
	{
		public static void EnableEmission(this ParticleSystem particleSystem, bool enabled)
		{
			var emission = particleSystem.emission;
			emission.enabled = enabled;
		}

		[System.Obsolete]
		public static float GetEmissionRate(this ParticleSystem particleSystem)
		{
			return particleSystem.emission.rate.constantMax;
		}

		[System.Obsolete]
		public static void SetEmissionRate(this ParticleSystem particleSystem, float emissionRate)
		{
			var emission = particleSystem.emission;
			var rate = emission.rate;
			rate.constantMax = emissionRate;
			emission.rate = rate;
		}
	}
}
