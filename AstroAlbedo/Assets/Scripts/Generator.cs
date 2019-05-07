using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject[] enemies;
	public GameObject player;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;
	public bool stop;

	int randEnemy;

	void Start () {
		StartCoroutine (waitSpawner ());
	}
	

	void Update () {
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
	}

	// Script for multiple enemies;
	IEnumerator waitSpawner () {
		yield return new WaitForSeconds (startWait);

		while (!stop) {
			//randEnemy = Random.Range (0, 2);

			Vector3 spawnPositon = new Vector3( Random.Range(-spawnValues.x, spawnValues.x), 0.5f, Random.Range(player.transform.position.z/2f , spawnValues.z));
			Instantiate(enemies[0], spawnPositon + transform.TransformPoint( 0, 0, 0), gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);
			
		}
	}
}
