using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser1 : MonoBehaviour {

    public float power = 100f;
    private int num_samples = 100;
    private float range = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(GameObject.Find("Crosshair").transform);
        Transform target = GameObject.Find("Crosshair").transform;
        transform.rotation = Quaternion.LookRotation(transform.position - target.position);

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            range += 30;
            target.GetComponent<CrosshairScript>().range += 30;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + 2400);
            
            Debug.Log("hello");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            range -= 30;
            target.GetComponent<CrosshairScript>().range -= 30;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z - 2400);
            if (range < 30)
            {
                range = 30;
                target.GetComponent<CrosshairScript>().range = 30;
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 2400);
            }
            Debug.Log("hello");
        }

        RaycastHit hit;
        float x = target.position.x;
        float y = target.position.y;
        float z = target.position.z;

        for (int i = 0; i < num_samples; i++) {
            float randx = Random.Range(x - 1.5f, x + 1.5f);
            float randy = Random.Range(y - 1.5f, y + 1.5f);
            float randz = Random.Range(z - 1.5f, z + 1.5f);
            Ray rand_ray = new Ray(transform.position, new Vector3(randx, randy, randz) - transform.position);
            if (Physics.Raycast(rand_ray, out hit, range)) {
                enemy Enemy = hit.transform.GetComponent<enemy>();
                if (Enemy != null) {
                    Enemy.applyDamage(power / num_samples);
                }
            }
        }
    }
}
