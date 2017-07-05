    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aluria : MonoBehaviour {

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
        GameObject aluria = this.gameObject;

        if (Input.GetKeyDown(KeyCode.A)) {
            aluria.GetComponent<Animation>().Play("idle");
            aluria.transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.D)) {
            aluria.GetComponent<Animation> ().Play ("idle");
            aluria.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.W)) {
            aluria.GetComponent<Animation> ().Play ("Walk");
            aluria.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            aluria.GetComponent<Animation> ().Play ("Walk");
            aluria.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.J) && mana >= 10) { //Habilidade 1
            aluria.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H1) as GameObject;
			fb.transform.position = aluria.transform.position + (aluria.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, 0.0f));
			fb.transform.rotation = aluria.transform.rotation;
            //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
            mana -= 10;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.K) && mana >= 15) { //Habilidade 2
            aluria.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H2) as GameObject;
			fb.transform.position = aluria.transform.position;
			fb.gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, 0.5f));
			fb.transform.rotation = aluria.transform.rotation;
            mana -= 15;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.L) && mana >= 35) { //Habilidade 3
            aluria.GetComponent<Animation> ().Play ("Attack");
			GameObject fba = Instantiate (H3) as GameObject;
			GameObject fbb = Instantiate (H3) as GameObject;
			GameObject fbc = Instantiate (H3) as GameObject;
			fba.transform.position = aluria.transform.position + (aluria.transform.forward);
			fba.gameObject.transform.Translate (new Vector3 (-1.25f, 0.05f, 2.0f));
			fba.transform.rotation = aluria.transform.rotation;

			fbb.transform.position = aluria.transform.position + (aluria.transform.forward);
			fbb.gameObject.transform.Translate (new Vector3 (-1.25f, 0.05f, 0.0f));
			fbb.transform.rotation = aluria.transform.rotation;

			fbc.transform.position = aluria.transform.position + (aluria.transform.forward);
			fbc.gameObject.transform.Translate (new Vector3 (-1.25f, 0.05f, -2.0f));
			fbc.transform.rotation = aluria.transform.rotation;
            mana -= 35;
            Debug.Log("Mana Atual: " + mana);
        }
        
		//Comando para limitar o plano (Não sair do plano)
		Vector3 pos = aluria.transform.position;
        aluria.transform.position = new Vector3 (Mathf.Clamp (pos.x, 1.25f, 48.75f), pos.y, Mathf.Clamp (pos.z, 1.25f, 48.75f));
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