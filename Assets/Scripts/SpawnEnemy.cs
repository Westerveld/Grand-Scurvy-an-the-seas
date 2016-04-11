using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class SpawnEnemy : MonoBehaviour {
	public Transform[] spawnLocations;
	public float spawnTime = 3f;
	public GameObject[] enemys;
	private GameManager manager;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn () {
		int spawnPointIndex = Random.Range (0, spawnLocations.Length);
		Instantiate (enemys[Random.Range (0,enemys.Length)], spawnLocations [spawnPointIndex].position, spawnLocations [spawnPointIndex].rotation);

	}
}
