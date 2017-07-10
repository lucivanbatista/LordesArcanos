using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lilith : MonoBehaviour {

	public GameObject H1;
	public GameObject H2;
	public GameObject H3;
	int passos = 0;
	int limitePassos;
	int mana = 500;
	int vida = 60;
	public Slider manaSlider;

    void Start () {
		limitePassos = 4;	
	}

	void Update () {
        GameObject lilith = this.gameObject;

        if (Input.GetKeyDown(KeyCode.F)) {
            lilith.GetComponent<Animation>().Play("idle");
            lilith.transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
        } 
		else if (Input.GetKeyDown(KeyCode.H)) {
            lilith.GetComponent<Animation> ().Play ("idle");
            lilith.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
        } 
		else if (Input.GetKeyDown(KeyCode.T)) {
            lilith.GetComponent<Animation> ().Play ("Walk");
            lilith.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
			passos++;
        } 
		else if (Input.GetKeyDown(KeyCode.G)) {
            lilith.GetComponent<Animation> ().Play ("Walk");
            lilith.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
			passos++;
        } 
		else if (Input.GetKeyDown(KeyCode.I) && mana >= 15) { //Habilidade 1
            lilith.GetComponent<Animation>().Play("Attack");
            GameObject fb = Instantiate(H1) as GameObject;
            fb.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
            fb.transform.position = (new Vector3(fb.transform.position.x, 1.0f, fb.transform.position.z));
            fb.transform.rotation = lilith.transform.rotation;
            fb.GetComponent<MovimentoHabilidade>().Direcao(lilith.transform.position);

            //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
            mana -= 15;
			manaSlider.value = mana;
        } else if (Input.GetKeyDown(KeyCode.O) && mana >= 15) { //Habilidade 2
            lilith.GetComponent<Animation> ().Play ("Attack");
            lilith.GetComponent<Animation>().Play("Attack");
            GameObject fba = Instantiate(H2) as GameObject;
            GameObject fbb = Instantiate(H2) as GameObject;
            GameObject fbc = Instantiate(H2) as GameObject;
            GameObject fbd = Instantiate(H2) as GameObject;
            GameObject fbe = Instantiate(H2) as GameObject;

            fba.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
            fba.transform.position = (new Vector3(fba.transform.position.x, 1.0f, fba.transform.position.z + 2.5f));
            fba.transform.rotation = lilith.transform.rotation;
            fba.GetComponent<MovimentoHabilidade>().Direcao(lilith.transform.position);

            fbb.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
            fbb.transform.position = (new Vector3(fbb.transform.position.x, 1.0f, fbb.transform.position.z));
            fbb.transform.rotation = lilith.transform.rotation;
            fbb.GetComponent<MovimentoHabilidade>().Direcao(lilith.transform.position);

            fbc.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
            fbc.transform.position = (new Vector3(fbc.transform.position.x, 1.0f, fbc.transform.position.z - 2.5f));
            fbc.transform.rotation = lilith.transform.rotation;
            fbc.GetComponent<MovimentoHabilidade>().Direcao(lilith.transform.position);

            fbd.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
            fbd.transform.position = (new Vector3(fbd.transform.position.x, 1.0f, fbd.transform.position.z + 5f));
            fbd.transform.rotation = lilith.transform.rotation;
            fbd.GetComponent<MovimentoHabilidade>().Direcao(lilith.transform.position);

            fbe.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
            fbe.transform.position = (new Vector3(fbe.transform.position.x, 1.0f, fbe.transform.position.z - 5f));
            fbe.transform.rotation = lilith.transform.rotation;
            fbe.GetComponent<MovimentoHabilidade>().Direcao(lilith.transform.position);

            mana -= 15;
			manaSlider.value = mana;
        } else if (Input.GetKeyDown(KeyCode.P) && mana >= 30) { //Habilidade 3
            lilith.GetComponent<Animation> ().Play ("Attack");
			GameObject fb = Instantiate (H3) as GameObject;
			fb.transform.position = lilith.transform.position + (lilith.transform.forward);
            fb.transform.rotation = lilith.transform.rotation;
            fb.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 5.0f));
            
            mana -= 30;
			manaSlider.value = mana;
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Mana")
        {
            mana += 20;
			manaSlider.value = mana;
            Destroy(col.gameObject);
        }
    }
}