using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float moveSpeed;
	public float speed = 2;
	public float hp;

	// Use this for initialization
	void Start () {
		moveSpeed = 1f;
		hp = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		//float rot;
		//transform.Translate (
		//	Input.GetAxis ("Alt Horizontal") * Time.deltaTime * moveSpeed,
		//	Input.GetAxis ("Alt Vertical") * Time.deltaTime * moveSpeed, 0f);
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 5 * Time.deltaTime, 0);
			transform.Rotate (-10 * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, -5 * Time.deltaTime, 0);
			transform.Rotate (10 * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-5 * Time.deltaTime, 0, 0);
			transform.Rotate (0, 0, 10 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (5 * Time.deltaTime, 0, 0);
			transform.Rotate (0, 0, -10 * Time.deltaTime);
		}
		if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
			StartCoroutine (rotateTowards(this.transform, Quaternion.identity, .5f));
		}
	}

	private IEnumerator rotateTowards(Transform target, Quaternion rot, float dur) {
		float t = 0f;
		Quaternion start = target.rotation;
		while (t < dur) {
			target.rotation = Quaternion.Slerp (start, rot, t / dur);
			yield return null;
			t += Time.deltaTime;
		}
		target.rotation = rot;
	}

	public void applyDamage(float amount) {
		hp -= amount;
		if (hp <= 0) {
			dead ();
		}
	}

	void dead() {
		//evaluateStep ();
		Destroy (gameObject);
	}
		
}
