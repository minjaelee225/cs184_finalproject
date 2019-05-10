using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject[] enemies;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;

	int randEnemy;
	private Vector3 pos;

	void Start () {
		StartCoroutine (waitSpawner ());
	}
	

	void Update () {
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
		pos = GameObject.FindGameObjectWithTag ("Player").transform.position;
	}

	// Script for multiple enemies;
	IEnumerator waitSpawner () {
		yield return new WaitForSeconds (startWait);

		while (!stop) {
			//randEnemy = Random.Range (0, 2);

			Vector3 spawnPositon = new Vector3( Random.Range(-spawnValues.x + pos.x, spawnValues.x + pos.x), 
				Random.Range(-spawnValues.y + pos.y, spawnValues.y + pos.y), 
				Random.Range(0, spawnValues.z + pos.z));
			Instantiate(enemies[0], spawnPositon + transform.TransformPoint( 0, 0, 0), new Quaternion(0, 180, 0, 1));
			yield return new WaitForSeconds (spawnWait);
			
		}
	}
}
