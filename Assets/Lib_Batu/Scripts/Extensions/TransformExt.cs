using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BKLib
{
	public static class TransformExt
	{
		public static void ResetTransform(this Transform t)
		{
			t.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
			t.localScale = Vector3.one;
		}

		public static void ResetLocalTransform(this Transform t)
		{
			t.localPosition = Vector3.zero;
			t.localRotation = Quaternion.identity;
			t.localScale = Vector3.one;
		}

		public static bool HasComponent<T>(this Transform t) where T : Component
		{
			if (t.TryGetComponent(out T requestedComponent))
			{
				return true;
			}
			return false;
		}

		public static List<Transform> GetAllChildren(this Transform t)
		{
			var children = new List<Transform>();

			// Iterate over all children in transform.
			foreach (Transform child in t)
			{
				children.Add(child);
			}
			return children;
		}
		public static void DestroyChildren(this Transform transform)
		{
			for (var i = transform.childCount - 1; i >= 0; i--)
			{
				Object.Destroy(transform.GetChild(i).gameObject);
			}
		}


		/// <summary>
		/// Look at a GameObject
		/// </summary>
		/// <param name="t"></param>
		/// <param name="target">The thing to look at</param>
		public static void LookTo(this Transform t, GameObject target)
		{
			t.LookAt(target.transform);
		}

		/// <summary>
		/// Find the rotation to look at a Vector3
		/// </summary>
		/// <param name="self"></param>
		/// <param name="target">The thing to look at</param>
		/// <returns></returns>
		public static Quaternion GetLookAtRotation(this Transform self, Vector3 target)
		{
			return Quaternion.LookRotation(target - self.position);
		}

		/// <summary>
		/// Find the rotation to look at a Transform
		/// </summary>
		/// <param name="self"></param>
		/// <param name="target">The thing to look at</param>
		/// <returns></returns>
		public static Quaternion GetLookAtRotation(this Transform self, Transform target)
		{
			return GetLookAtRotation(self, target.position);
		}

		#region LookAway

		/// <summary>
		/// Instantly look away from a target transform
		/// </summary>
		/// <param name="self"></param>
		/// <param name="target">The thing to look away from</param>
		public static void LookAwayFrom(this Transform self, Transform target)
		{
			self.rotation = GetLookAwayFromRotation(self, target);
		}

		/// <summary>
		/// Find the rotation to look away from a target Vector3
		/// </summary>
		/// <param name="self"></param>
		/// <param name="target">The thing to look away from</param>
		public static Quaternion GetLookAwayFromRotation(this Transform self, Vector3 target)
		{
			return Quaternion.LookRotation(self.position - target);
		}

		/// <summary>
		/// Find the rotation to look away from a target transform
		/// </summary>
		/// <param name="self"></param>
		/// <param name="target">The thing to look away from</param>
		public static Quaternion GetLookAwayFromRotation(this Transform self, Transform target)
		{
			return GetLookAwayFromRotation(self, target.position);
		}

		#endregion


	}
}

