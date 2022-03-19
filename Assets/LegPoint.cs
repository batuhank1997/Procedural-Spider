using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegPoint : MonoBehaviour
{
	[SerializeField] private float distance;

	// Update is called once per frame
	void Update()
	{
		Ray ray = new Ray(transform.position, -transform.up);

		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, Mathf.Infinity))
		{
			transform.position = hit.point + Vector3.up * distance;
		}
	}
}
