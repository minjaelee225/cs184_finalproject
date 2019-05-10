using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float moveSpeed;
	public float speed = 2;
	public int hp;

	// Use this for initialization
	void Start () {
		moveSpeed = 1f;
		hp = 10;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (
		//	Input.GetAxis ("Alt Horizontal") * Time.deltaTime * moveSpeed,
		//	Input.GetAxis ("Alt Vertical") * Time.deltaTime * moveSpeed, 0f);
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 5 * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, -5 * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-5 * Time.deltaTime, 0, 0);
			transform.Rotate (0, 0, 20 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (5 * Time.deltaTime, 0, 0);
		}
	}
}
