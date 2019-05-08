using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public float hp = 3f;

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
