using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third_person_camera : MonoBehaviour {

	private const float X_ANGLE_MIN = -10.0f;
	private const float X_ANGLE_MAX = 10.0f;
	private const float Y_ANGLE_MIN = -10.0f;
	private const float Y_ANGLE_MAX = 10.0f;

	public Transform lookAt;
	public Transform camTransform;
	Vector3 offset = new Vector3 (0, 1.5f, -16f);

	private Camera cam;

	private float distance = 5.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	//private float sensitivityX = 4.0f;
	//private float sensitivityY = 1.0f;

	private void Start() {
		camTransform = transform;
		//camTransform.position = offset;
		cam = Camera.main;
	}

	private void Update() {
		currentX += Input.GetAxis ("Mouse X");
		//currentY -= Input.GetAxis ("Mouse Y");

		currentX = Mathf.Clamp (currentX, X_ANGLE_MIN, X_ANGLE_MAX);
		//currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}

	/*private void LateUpdate() {
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (0, currentX, 0);
		Debug.Log (lookAt.position);
		camTransform.position = offset + rotation * dir;
		camTransform.LookAt (lookAt.position);
	}*/
}
