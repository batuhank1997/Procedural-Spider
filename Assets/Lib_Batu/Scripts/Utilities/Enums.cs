using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationType
{
	Idle = 0,
	Running = 1,
}

public enum ItemType
{
	Default,
	Edibles,
}

public static class Enums
{
	public static bool IsRunOrIdle(this AnimationType type) => type == AnimationType.Idle || type == AnimationType.Running;
}
