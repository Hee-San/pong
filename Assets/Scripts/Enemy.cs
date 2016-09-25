using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 8;
	Vector3 targetPos;
	GameObject ballObj;

	void Start () {
		ballObj = GameObject.FindGameObjectWithTag("Ball");
	}
	
	void Update () {
		targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
		gameObject.transform.position = new Vector3 (2.5f, Mathf.Clamp (targetPos.y, -1.55f, 1.55f), 0);
	}
}
