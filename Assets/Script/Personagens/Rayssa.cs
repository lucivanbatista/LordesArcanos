    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayssa : MonoBehaviour {

	public GameObject H1;
	public GameObject H3;
	int passos = 0;
	int limitePassos;
	int mana = 500;
	int vida = 60;

    void Start () {
		limitePassos = 4;	
	}

	void Update () {
        GameObject rayssa = this.gameObject;

        if (Input.GetKeyDown(KeyCode.A)) {
            rayssa.GetComponent<Animation>().Play("idle");
            rayssa.transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.D)) {
            rayssa.GetComponent<Animation> ().Play ("idle");
            rayssa.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.W)) {
            rayssa.GetComponent<Animation> ().Play ("Walk");
            rayssa.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            rayssa.GetComponent<Animation> ().Play ("Walk");
            rayssa.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
			passos++;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.J) && mana >= 20) { //Habilidade 1
            rayssa.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H1) as GameObject;
			fb.transform.position = rayssa.transform.position + (rayssa.transform.forward);
			fb.gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, 0.0f));
			fb.transform.rotation = rayssa.transform.rotation;
            //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
            mana -= 20;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.K) && mana >= 5) { //Habilidade 2
            rayssa.GetComponent<Animation> ().Play ("Attack");
            passos -= 2;
            mana -= 5;
            Debug.Log("Mana Atual: " + mana);
        } else if (Input.GetKeyDown(KeyCode.L) && mana >= 35) { //Habilidade 3
            rayssa.GetComponent<Animation> ().Play ("Attack");
			GameObject fb1 = Instantiate (H3) as GameObject;

            /*GameObject fb4 = Instantiate(H3) as GameObject;
            GameObject fb5 = Instantiate(H3) as GameObject;
            GameObject fb6 = Instantiate(H3) as GameObject;
            GameObject fb7 = Instantiate(H3) as GameObject;
            GameObject fb8 = Instantiate(H3) as GameObject;
            GameObject fb9 = Instantiate(H3) as GameObject;*/

            fb1.transform.position = rayssa.transform.position;

            /*fb4.transform.position = rayssa.transform.position;
            fb5.transform.position = rayssa.transform.position;
            fb6.transform.position = rayssa.transform.position;
            fb7.transform.position = rayssa.transform.position;
            fb8.transform.position = rayssa.transform.position;
            fb9.transform.position = rayssa.transform.position;*/

            fb1.gameObject.transform.Translate(new Vector3(10.0f, 0.05f, 0.0f));
            
            /*fb4.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb5.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb6.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb7.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb8.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb9.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));*/


            mana -= 35;
            Debug.Log("Mana Atual: " + mana);
        }
        
		//Comando para limitar o plano (Não sair do plano)
		Vector3 pos = rayssa.transform.position;
        rayssa.transform.position = new Vector3 (Mathf.Clamp (pos.x, 1.25f, 48.75f), pos.y, Mathf.Clamp (pos.z, 1.25f, 48.75f));
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