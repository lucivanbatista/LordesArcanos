    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lilith : MonoBehaviour {

	public GameObject H1;
	public GameObject H2;
	public GameObject H3;
	int passos = 0;
	int limitePassos;
	int mana = 500;
	int vida = 60;

    void Start () {
		limitePassos = 4;	
	}

	void Update () {
        GameObject lilith = this.gameObject;

        if (Input.GetKeyDown(KeyCode.F)) {
            lilith.GetComponent<Animation>().Play("idle");
            lilith.transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.H)) {
            lilith.GetComponent<Animation> ().Play ("idle");
            lilith.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.T)) {
            lilith.GetComponent<Animation> ().Play ("Walk");
            lilith.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.G)) {
            lilith.GetComponent<Animation> ().Play ("Walk");
            lilith.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.I) && mana >= 15) { //Habilidade 1
            lilith.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H1) as GameObject;
			fb.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
			fb.gameObject.transform.Translate (new Vector3 (-0.5f, 1.0f, 0.0f));
            fb.transform.rotation = lilith.transform.rotation;
            //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
            mana -= 15;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.O) && mana >= 15) { //Habilidade 2
            lilith.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H2) as GameObject;
			fb.transform.position = lilith.transform.position + (lilith.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (-1.25f, 0.05f, 2.0f));
			fb.transform.rotation = lilith.transform.rotation;
            mana -= 15;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.P) && mana >= 30) { //Habilidade 3
            lilith.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H3) as GameObject;
			fb.transform.position = lilith.transform.position + (lilith.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (-1.25f, 0.05f, 2.0f));
			fb.transform.rotation = lilith.transform.rotation;
            mana -= 30;
            Debug.Log("Mana Atual: " + mana);
        }
        
		//Comando para limitar o plano (Não sair do plano)
		Vector3 pos = lilith.transform.position;
        lilith.transform.position = new Vector3 (Mathf.Clamp (pos.x, 1.25f, 48.75f), pos.y, Mathf.Clamp (pos.z, 1.25f, 48.75f));
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