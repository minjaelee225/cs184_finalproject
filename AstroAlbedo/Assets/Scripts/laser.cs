using UnityEngine;

public class laser : MonoBehaviour {

	public float damage = 1f;
	public float range = 100f;

	public Camera camera;

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			shoot ();
		}
	}

	void shoot() {
		RaycastHit hit;
		Ray ray = camera.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray, out hit, range)) {
			enemy Enemy = hit.transform.GetComponent<enemy> ();
			if (Enemy != null) {
				Enemy.applyDamage (damage);
			}

		}
	}

}
