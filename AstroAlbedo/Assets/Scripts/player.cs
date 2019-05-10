using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	private const float X_ANGLE_MIN = -1f;
	private const float X_ANGLE_MAX = 1f;
	private const float Y_ANGLE_MIN = -10.0f;
	private const float Y_ANGLE_MAX = 10.0f;

	public float moveSpeed;
	public float speed = 10;
	public int hp;

	// Use this for initialization
	void Start () {
		moveSpeed = 1f;
		hp = 10;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (moveSpeed * Input.GetAxis ("Alt Horizontal") * Time.deltaTime, moveSpeed * Input.GetAxis ("Alt Vertical") * Time.deltaTime, 0f);
	}
}
