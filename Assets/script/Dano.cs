using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour {

	int vida = 60;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(vida <= 0){
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Class 1"){
			vida -= 5;
			Debug.Log(this.gameObject.tag + "Vida Collider: " + vida);
		}
		if(col.gameObject.tag == "Class 2"){
			vida -= 10;
			Debug.Log(this.gameObject.tag + "Vida Collider: " + vida);
		}
		if(col.gameObject.tag == "Class 3"){
			vida -= 15;
			Debug.Log(this.gameObject.tag + "Vida Collider: " + vida);
		}
		if(col.gameObject.tag == "Class 4"){
			vida -= 20;
			Debug.Log(this.gameObject.tag + "Vida Collider: " + vida);
		}
		if(col.gameObject.tag == "Class 5"){
			vida -= 40;
			Debug.Log(this.gameObject.tag + "Vida Collider: " + vida);
		}
	}
}
