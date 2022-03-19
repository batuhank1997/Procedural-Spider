using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONHelper : MonoBehaviour
{
	public ItemsList numsInJSON = new ItemsList();

	[System.Serializable]
	public class ItemsList
	{
		public int[] matrix;
	}

	private TextAsset jsonFile;

	void Awake()
	{
		jsonFile = Resources.Load<TextAsset>("JSONData");

		numsInJSON = JsonUtility.FromJson<ItemsList>(jsonFile.text);
	}
}
