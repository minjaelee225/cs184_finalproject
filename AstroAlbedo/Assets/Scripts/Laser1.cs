using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        //transform.LookAt(target);

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            range += 10;
            target.GetComponent<CrosshairScript>().range += 10;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + 800);

            Debug.Log("hello");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            range -= 10;
            target.GetComponent<CrosshairScript>().range -= 10;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z - 800);
            if (range < 10)
            {
                range = 10;
                target.GetComponent<CrosshairScript>().range = 10;
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 800);
            }
            Debug.Log("hello");
        }

        float totalDamage = 0f;

        RaycastHit hit;
        float x = target.position.x;
        float y = target.position.y;
        float z = target.position.z;

        for (int i = 0; i < num_samples; i++) {
            float randx = Random.Range(x - 1.5f, x + 1.5f);
            float randy = Random.Range(y - 1.5f, y + 1.5f);
            float randz = Random.Range(z - 1.5f, z + 1.5f);
            Ray rand_ray = new Ray(transform.position, new Vector3(randx, randy, randz) - transform.position);
            //Ray rand_ray = new Ray(Camera.main.transform.position, new Vector3(randx, randy, randz) - transform.position);
            if (Physics.Raycast(rand_ray, out hit, range)) {
                enemy Enemy = hit.transform.GetComponent<enemy>();
                if (Enemy != null) {
                    Enemy.applyDamage(power / num_samples);
                    totalDamage += power/num_samples;
                }
            }
        }
        GameObject.FindGameObjectWithTag("Text").GetComponent<Text>().text = "Damage: " + totalDamage;
    }
}
