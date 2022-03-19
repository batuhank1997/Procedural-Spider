using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stabilizer : MonoBehaviour
{
    [SerializeField] Transform body;
    [SerializeField] Transform[] legs;
    [SerializeField] float diff;

    // Update is called once per frame
    void Update()
    {
        float averageYpos = (legs[0].position + legs[1].position + legs[2].position + legs[3].position).y / 4;

		body.position = new Vector3(transform.position.x, averageYpos + diff, transform.position.z);
	}
}
