using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoZombie : MonoBehaviour {
	float step;

	// Use this for initialization
	void Start () {
		step = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 posicaoPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
		this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, posicaoPlayer, step);
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "power")
		{
			Destroy(this.gameObject);
		}
		if (col.gameObject.tag == "Player")
		{
			Debug.Log("Morreu");
		}
	}
}
