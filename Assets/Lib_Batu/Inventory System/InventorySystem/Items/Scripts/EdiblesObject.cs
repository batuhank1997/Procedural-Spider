using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Edibles Object", menuName = "Scriptables/Inventory System/Items/Edible")]
public class EdiblesObject : ItemObject
{
	private void Awake()
	{
		type = ItemType.Edibles;
	}
}
