using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
	[SerializeField] float lerpTime;

	private void Start()
	{
		offset = target.position - transform.position;
	}

	// Update is called once per frame
	void Update()
    {
		transform.position = Vector3.Lerp(transform.position, target.transform.position - offset, lerpTime);
    }
}
