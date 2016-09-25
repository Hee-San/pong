using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1;
	public Vector3 playerPos;
	
	void Update () {
		float yPos = transform.position.y + (Input.GetAxis ("Vertical") * paddleSpeed);
		Vector3 playerPos = new Vector3 (-2.5f, Mathf.Clamp (yPos, -1.45f, 1.45f), 0);
		transform.position = playerPos;
	}
}
