using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class UIObjects : MonoBehaviour
{
	[SerializeField] private Vector3 rotation;
	private Transform child;

	readonly char[] arr = { '(', 'C', 'l', 'o', 'n', 'e', ')' };

	RectTransform rectTransform;
	Vector3 startPosition;
	Vector3 endPosition;

	float timeOfTravel = 5; //time after object reach a target place 
	float currentTime = 0; // actual floting time 
	float normalizedValue;

	private void Start()
	{
		child = transform.GetChild(0);
		GetComponentInChildren<TextMeshPro>().text = gameObject.name.TrimEnd(arr);
		rectTransform = GetComponent<RectTransform>(); //getting reference to this component 

		startPosition = GetComponent<RectTransform>().localPosition;
		endPosition = GameObject.Find("InventoryButton").GetComponent<RectTransform>().localPosition;
	}

	// Update is called once per frame
	void Update()
	{
		child.transform.Rotate(rotation);
	}

	public void LerpMe()
	{
		StartCoroutine(LerpObject());
	}

	IEnumerator LerpObject()
	{
		print("lerp me");

		while (currentTime <= timeOfTravel / 4)
		{
			currentTime += Time.deltaTime;
			normalizedValue = (currentTime * 4f) / (timeOfTravel); // we normalize our time 
			

			rectTransform.anchoredPosition = Vector3.Lerp(startPosition, endPosition, normalizedValue);
			yield return null;
		}

		Destroy(gameObject);
	}
}
