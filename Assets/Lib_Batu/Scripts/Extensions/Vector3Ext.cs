using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
    public static class Vector3Ext
    {
		public static Vector3 SetX(this Vector3 v, float x)
		{
			return new Vector3(x, v.y, v.z);
		}

		public static Vector3 SetY(this Vector3 v, float y)
		{
			return new Vector3(v.x, y, v.z);
		}

		public static Vector3 SetZ(this Vector3 v, float z)
		{
			return new Vector3(v.x, v.y, z);
		}

		public static Vector3 V2ToV3WithZ(this Vector2 v, float z)
		{
			return new Vector3(v.x, v.y, z);
		}

        public static Vector3 AddXVal(this Vector3 v, float x)
        {
            return new Vector3(v.x + x, v.y, v.z);
        }

        public static Vector3 AddYVal(this Vector3 v, float y)
        {
            return new Vector3(v.x, v.y + y, v.z);
        }

        public static Vector3 AddZVal(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, v.z + z);
        }

        public static Vector3 SetVector(this Vector3 v, float x, float y, float z)
        {
            v.x = x; v.y = y; v.z = z;
            return v;
        }

        // axisDirection - unit vector in direction of an axis (eg, defines a line that passes through zero)
        // point - the point to find nearest on line for
        public static Vector3 NearestPointOnAxis(this Vector3 axisDirection, Vector3 point, bool isNormalized = false)
        {
            if (!isNormalized) axisDirection.Normalize();
            var d = Vector3.Dot(point, axisDirection);
            return axisDirection * d;
        }

        // lineDirection - unit vector in direction of line
        // pointOnLine - a point on the line (allowing us to define an actual line in space)
        // point - the point to find nearest on line for
        public static Vector3 NearestPointOnLine(this Vector3 lineDirection, Vector3 point, Vector3 pointOnLine, bool isNormalized = false)
        {
            if (!isNormalized) lineDirection.Normalize();
            var d = Vector3.Dot(point - pointOnLine, lineDirection);
            return pointOnLine + (lineDirection * d);
        }
    }

}
