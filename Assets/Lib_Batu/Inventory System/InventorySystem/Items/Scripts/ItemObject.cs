using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemObject : ScriptableObject
{
	[SerializeField] public GameObject prefab;
	[SerializeField] protected ItemType type;

	protected GameObject Prefab { get => prefab; set => prefab = value; }
}
