using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrior : MonoBehaviour {

	public GameObject Fireball;
	int passos = 0;
	int limitePassos;
	int mana = 50;
	int vida = 60;

	void Start () {
		limitePassos = 4;	
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			this.gameObject.GetComponent<Animation> ().Play("Walk");

			this.gameObject.transform.Rotate (new Vector3(0.0f, -90f, 0.0f));
		}else if (Input.GetKeyDown(KeyCode.RightArrow)){
			this.gameObject.GetComponent<Animation> ().Play("Walk");

			this.gameObject.transform.Rotate (new Vector3(0.0f, 90f, 0.0f));
		}else if (Input.GetKeyDown(KeyCode.UpArrow)){
			this.gameObject.GetComponent<Animation> ().Play("Walk");
			this.gameObject.transform.Translate(new Vector3(0.0f, 0.0f, 2.5f));
			passos++;
		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			this.gameObject.GetComponent<Animation> ().Play("Walk");
			this.gameObject.transform.Translate(new Vector3(0.0f, 0.0f, -2.5f));
			passos++;
		}else if(Input.GetKeyDown(KeyCode.Space)){
			this.gameObject.GetComponent<Animation> ().Play("Attack");
			GameObject fb = Instantiate (Fireball) as GameObject;
			fb.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (-0.5f, 1.0f, 0.0f));
			fb.transform.rotation = this.gameObject.transform.rotation;
			fb.GetComponent<Rigidbody>().AddForce(Fireball.transform.forward * 500.0f);
		}
		Vector3 pos = this.gameObject.transform.position;
		this.gameObject.transform.position = new Vector3(Mathf.Clamp(pos.x, 1.25f , 48.75f), pos.y, Mathf.Clamp(pos.z, 1.25f, 48.75f));
	}
}