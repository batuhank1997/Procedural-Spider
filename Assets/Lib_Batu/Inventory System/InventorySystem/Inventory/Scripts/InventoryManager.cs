using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
	[SerializeField] private InventoryObject playerInventory;

	private void Start()
	{
		GameManager.Instance.GameWin += () => 
		{ 
			//CanvasManager.Instance.InventoryUpdate?.Invoke();
		};
	}
}
