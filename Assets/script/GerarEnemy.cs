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
		if (Time.time - tempo > 2.0f)
		{
			GameObject enemy = Instantiate (prefab) as GameObject;
			float x = Random.Range (-12, 12);
			float z = Random.Range (-12, 12);
			//int i = Random.Range(0, 6);

			enemy.transform.position = new Vector3(x, 1.0f, z);

			tempo = Time.time;
		}
	}
}
