using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public float hp = 3f;
	public float moveSpeed = 3f;
	public GameObject player;
	Vector3 position;

	void Start ()
	{
		position = player.transform.position;
	}

	void Update () {
		transform.Translate (0f, 0f, moveSpeed * 1 * Time.deltaTime);
		if (transform.position.z < position.z - 10) {
			Destroy (gameObject);
		}
	}

	public void applyDamage(float amount) {
		hp -= amount;
		if (hp <= 0) {
			dead ();
		}
	}

	void dead() {
		Destroy (gameObject);
	}
}
