﻿using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {
	
	[SerializeField]private Transform target;

	private float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;

	void Update () 
	{
		if (target)
		{
			Vector3 point = Camera.main.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	}
}
