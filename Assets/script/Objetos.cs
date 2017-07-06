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

		if(col.gameObject.tag == "Class 1" || col.gameObject.tag == "Class 2" || col.gameObject.tag == "Class 3" || col.gameObject.tag == "Class 4" || col.gameObject.tag == "Class 5")
		{
			Destroy(col.gameObject);
		}
	}
}
