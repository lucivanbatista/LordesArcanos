    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarir : MonoBehaviour {

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
        GameObject tarir = this.gameObject;

        if (Input.GetKeyDown(KeyCode.Y)) {
            tarir.GetComponent<Animation>().Play("idle");
            tarir.transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.I)) {
            tarir.GetComponent<Animation> ().Play ("idle");
            tarir.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.Alpha7)) {
            tarir.GetComponent<Animation> ().Play ("Walk");
            tarir.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.U)) {
            tarir.GetComponent<Animation> ().Play ("Walk");
            tarir.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.Alpha8) && mana >= 10) { //Habilidade 1
            tarir.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H1) as GameObject;
			fb.transform.position = tarir.transform.position + (tarir.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, 0.0f));
			fb.transform.rotation = tarir.transform.rotation;
            //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
            mana -= 10;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.Alpha9) && mana >= 10) { //Habilidade 2
            tarir.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H2) as GameObject;
            fb.transform.position = new Vector3(20.0f, 0.05f, 20.0f);
            mana -= 10;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.Alpha0) && mana >= 20) { //Habilidade 3
            tarir.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H3) as GameObject;
			fb.transform.position = new Vector3(20.0f, 2.0f, 25.0f);
            mana -= 20;
            Debug.Log("Mana Atual: " + mana);
        }
        
		//Comando para limitar o plano (Não sair do plano)
		Vector3 pos = tarir.transform.position;
        tarir.transform.position = new Vector3 (Mathf.Clamp (pos.x, 1.25f, 48.75f), pos.y, Mathf.Clamp (pos.z, 1.25f, 48.75f));
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