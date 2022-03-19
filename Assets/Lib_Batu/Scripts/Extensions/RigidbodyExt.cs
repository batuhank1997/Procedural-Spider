using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BKLib
{
	public static class RigidbodyExt
	{
		public static void ChangeDirection(this Rigidbody rb, Vector3 direction)
		{
			rb.velocity = direction.normalized * rb.velocity.magnitude;
		}

		public static void NormalizeVelocity(this Rigidbody rb, float magnitude = 1)
		{
			rb.velocity = rb.velocity.normalized * magnitude;
		}

		public static void Freeze(this Rigidbody rb)
		{
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.isKinematic = true;
		}

		public static void FreezeAllConstraints(this Rigidbody rb)
		{
			rb.constraints = RigidbodyConstraints.FreezeAll;
		}

		public static void TurnOnAndOffConstraints(this Rigidbody rb)
		{
			rb.constraints = ~RigidbodyConstraints.FreezeAll;
		}
	}
}


