using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LegTarget : MonoBehaviour
{
    [SerializeField] private Transform leg;

    [SerializeField] private float distance;

    bool legCheck;

    // Update is called once per frame
    void Update()
    {
		if (!legCheck && Vector3.Distance(transform.position, leg.transform.position) > distance)
		{
            legCheck = true;
            transform.DOJump(leg.position, 0.05f, 1, 0.3f).OnComplete(() => legCheck = false);
            //transform.DOMove(leg.position, 0.3f).OnComplete(() => legCheck = false);
		}
    }
}
