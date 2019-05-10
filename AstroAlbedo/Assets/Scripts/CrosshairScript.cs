using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour {

    public float range = 100f;
    
    public Vector3 mousePosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        mousePosition = mouseRay.origin + Vector3.Normalize(mouseRay.direction) * range;
        //mousePosition.z = 10f;
        transform.position = mousePosition;
        transform.LookAt(GameObject.Find("Player").transform, -Vector3.up);
    }
}
