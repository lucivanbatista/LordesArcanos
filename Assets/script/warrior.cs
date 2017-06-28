    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrior : MonoBehaviour {

	public GameObject Fireball;
	public GameObject WallOfFire;
	public GameObject MeteorSwarm;
	int passos = 0;
	int limitePassos;
	int mana = 500;
	int vida = 60;

    void Start () {
		limitePassos = 4;	
	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            this.gameObject.GetComponent<Animation>().Play("idle");
            this.gameObject.transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			this.gameObject.GetComponent<Animation> ().Play ("idle");
			this.gameObject.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            this.gameObject.GetComponent<Animation> ().Play ("Walk");
			this.gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			this.gameObject.GetComponent<Animation> ().Play ("Walk");
			this.gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.Alpha1) && mana >= 15) { //Habilidade 1
			this.gameObject.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (Fireball) as GameObject;
			fb.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward) * 2;
			fb.gameObject.transform.Translate (new Vector3 (-0.5f, 1.0f, 0.0f));
			fb.transform.rotation = this.gameObject.transform.rotation;
            mana -= 15;
            Debug.Log("Mana Atual: " + mana);
            //fb.GetComponent<Rigidbody> ().AddForce (Fireball.transform.forward * 500.0f);
            /*if(fb.gameObject.transform.position.x >= this.gameObject.transform.position.x + (4.0f * 1.25f) || 
				fb.gameObject.transform.position.z >= this.gameObject.transform.position.z + (4.0f * 1.25f)){
				Debug.Log ("ENTROU");
				Destroy (fb);
			}*/
        } else if (Input.GetKeyDown(KeyCode.Alpha2) && mana >= 15) { //Habilidade 2
			this.gameObject.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (WallOfFire) as GameObject;
			fb.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (-1.25f, 0.05f, 2.0f));
			fb.transform.rotation = this.gameObject.transform.rotation;
            mana -= 15;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.Alpha3) && mana >= 35) { //Habilidade 3
			this.gameObject.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (MeteorSwarm) as GameObject;
			fb.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (-1.25f, 0.05f, 2.0f));
			fb.transform.rotation = this.gameObject.transform.rotation;
            mana -= 35;
            Debug.Log("Mana Atual: " + mana);
        }
        
		//Comando para limitar o plano (Não sair do plano)
		Vector3 pos = this.gameObject.transform.position;
		this.gameObject.transform.position = new Vector3 (Mathf.Clamp (pos.x, 1.25f, 48.75f), pos.y, Mathf.Clamp (pos.z, 1.25f, 48.75f));
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Life")
        {
            vida += 20;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Mana")
        {
            mana += 20;
            Destroy(col.gameObject);
        }
    }
}