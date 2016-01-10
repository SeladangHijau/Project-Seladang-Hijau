﻿using UnityEngine;
using System;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	public Transform target;
	public float speed;

	void FixedUpdate () {
		transform.position = Vector3.Lerp (transform.position, new Vector3(target.position.x, target.position.y, -10), speed);
	}
}