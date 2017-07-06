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
            fb.transform.rotation = lilith.transform.rotation;
            fb.gameObject.transform.Translate (new Vector3 (-0.5f, 1.0f, 0.0f));
            
            //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
            mana -= 15;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.O) && mana >= 15) { //Habilidade 2
            lilith.GetComponent<Animation> ().Play ("Attack");
            lilith.GetComponent<Animation>().Play("Attack");
            GameObject fba = Instantiate(H2) as GameObject;
            GameObject fbb = Instantiate(H2) as GameObject;
            GameObject fbc = Instantiate(H2) as GameObject;
            GameObject fbd = Instantiate(H2) as GameObject;
            GameObject fbe = Instantiate(H2) as GameObject;
            fba.transform.position = lilith.transform.position + (lilith.transform.forward);
            fba.transform.rotation = lilith.transform.rotation;
            fba.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 0.0f));

            fbb.transform.position = lilith.transform.position + (lilith.transform.forward);
            fbb.transform.rotation = lilith.transform.rotation;
            fbb.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, 0.0f));
            
            fbc.transform.position = lilith.transform.position + (lilith.transform.forward);
            fbc.transform.rotation = lilith.transform.rotation;
            fbc.gameObject.transform.Translate(new Vector3(1.25f, 0.05f, 0.0f));
            
            fbd.transform.position = lilith.transform.position + (lilith.transform.forward);
            fbd.transform.rotation = lilith.transform.rotation;
            fbd.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 0.0f));
            
            fbe.transform.position = lilith.transform.position + (lilith.transform.forward);
            fbe.transform.rotation = lilith.transform.rotation;
            fbe.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, 0.0f));
           
            mana -= 15;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.P) && mana >= 30) { //Habilidade 3
            lilith.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H3) as GameObject;
			fb.transform.position = lilith.transform.position + (lilith.transform.forward);
            fb.transform.rotation = lilith.transform.rotation;
            fb.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 5.0f));
            
            mana -= 30;
            Debug.Log("Mana Atual: " + mana);
        }
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