using UnityEngine;

public class laser : MonoBehaviour {

	public float damage = 1f;
	public float range = 100f;

	public GameObject playerCam;

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			shoot ();
		}
	}

	void shoot() {
		RaycastHit hit;
		if (Physics.Raycast (playerCam.transform.position, playerCam.transform.forward, out hit, range)) {
			Debug.Log (hit.transform.name);
			enemy Enemy = hit.transform.GetComponent<enemy> ();
			if (Enemy != null) {
				Enemy.applyDamage (damage);
			}

		}
	}

}
