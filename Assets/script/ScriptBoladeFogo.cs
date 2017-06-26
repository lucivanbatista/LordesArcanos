using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBoladeFogo : MonoBehaviour {


	void Start () {
		
	}

	void Update () {
		this.gameObject.transform.Translate(this.gameObject.transform.up * 0.01f);

		if(this.gameObject.transform.position.y > 1.15f){
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "zombie")
		{
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}
	}
}