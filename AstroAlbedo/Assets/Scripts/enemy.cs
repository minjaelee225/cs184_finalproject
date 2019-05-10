using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class enemy : MonoBehaviour {

	private float hp = 1000f;
	public float moveSpeed = 3f;
	private Vector3 pos;

	void Start () {
		pos = GameObject.FindGameObjectWithTag ("Player").transform.position;
	}

	void Update () {
		pos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		//transform.Translate (0f, 0f, moveSpeed * 1 * Time.deltaTime);
		if (transform.position.z < pos.z - 10) {
			dead ();
		}
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
