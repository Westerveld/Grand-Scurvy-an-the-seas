using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SpawnWaves : MonoBehaviour {
	
	public Transform[] spawnLocations;
	private bool waveOnScreen;
	public GameObject[] Waves;
	public float spawnTime;

	void Start(){
		InvokeRepeating ("SpawnNow",0, spawnTime);
	}

	void SpawnNow(){
		int spawnPointIndex = Random.Range (0, spawnLocations.Length);
		Instantiate (Waves [Random.Range (0, Waves.Length)], spawnLocations[spawnPointIndex].position, spawnLocations[spawnPointIndex].rotation);
	}
}
