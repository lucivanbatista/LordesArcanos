using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarEnemy : MonoBehaviour {

	public GameObject prefab;
	float tempo;

	void Start () {
		tempo = Time.time;
	}

	void Update () {
		if (Time.time - tempo > 5.0f)
		{
			GameObject enemy = Instantiate (prefab) as GameObject;
			float x = Random.Range (0, 50);
			float z = Random.Range (0, 50);
			//int i = Random.Range(0, 6);

			enemy.transform.position = new Vector3(x, 0.05f, z);

			tempo = Time.time;
		}
	}
}
