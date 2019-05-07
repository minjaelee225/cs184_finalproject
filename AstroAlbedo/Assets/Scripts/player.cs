using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float moveSpeed;
	public int hp;

	// Use this for initialization
	void Start () {
		moveSpeed = 1f;
		hp = 10;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (moveSpeed * Input.GetAxis ("Alt Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis ("Alt Vertical") * Time.deltaTime);
	}
}
