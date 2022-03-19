using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
	[SerializeField] private InventoryObject inventory;
	[SerializeField] private Vector2 startPos;

	[SerializeField] private int xSpaceBetweenItem;
	[SerializeField] private int ySpaceBetweenItem;
	[SerializeField] private int numberOfColoumns;

	Dictionary<InventorySlot, GameObject> itemsToDisplay = new Dictionary<InventorySlot, GameObject>();

	// Start is called before the first frame update
	void Start()
	{
		CreateDisplay();
	}

	void UpdateInventory()
	{
		for (int i = 0; i < inventory.container.Count; i++)
		{
			var obj = Instantiate(inventory.container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
			obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
		}
	}

	void CreateDisplay()
	{
		for (int i = 0; i < inventory.container.Count; i++)
		{
			var obj = Instantiate(inventory.container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
			obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
		}
	}

	private Vector3 GetPosition(int i)
	{
		return new Vector3(startPos.x + (xSpaceBetweenItem * (i % numberOfColoumns)), startPos.y + (-ySpaceBetweenItem * (i / numberOfColoumns)), 0);
	}
}
