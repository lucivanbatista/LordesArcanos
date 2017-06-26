using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Trap") {
			other.gameObject.GetComponent<Animation> ().Play("Up Down");
		}
	}
	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("Colisão");

		/*if(col.gameObject.tag == "power")
		{
			Destroy(this.gameObject);
		}*/
	}
}
