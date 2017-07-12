using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lilith : MonoBehaviour {

	public GameObject H1;
	public GameObject H2;
	public GameObject H3;
    public GameObject T;
	int passos = 0;
	int limitePassos;
	int mana = 500;
	int vida = 60;
	public Slider manaSlider;
	bool ative;
	void Start () {
		limitePassos = 4;
		ative = false;
	}

	void Update () {
		GameObject lilith = this.gameObject;
		if (ative) {
			if (Input.GetKeyDown (KeyCode.A)) {
				lilith.GetComponent<Animation> ().Play ("idle");
				lilith.transform.Rotate (new Vector3 (0.0f, -90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.D)) {
				lilith.GetComponent<Animation> ().Play ("idle");
				lilith.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.W) && passos < limitePassos) {
				lilith.GetComponent<Animation> ().Play ("Walk");
				lilith.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.S) && passos < limitePassos) {
				lilith.GetComponent<Animation> ().Play ("Walk");
				lilith.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.Alpha1) && mana >= 15) { //Habilidade 1
				lilith.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H1) as GameObject;
				fb.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
				fb.transform.position = (new Vector3 (fb.transform.position.x, 1.0f, fb.transform.position.z));
				fb.transform.rotation = lilith.transform.rotation;
				fb.GetComponent<MovimentoHabilidade> ().Direcao (lilith.transform.position);             

                //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
                mana -= 15;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.Alpha2) && mana >= 15) { //Habilidade 2
				lilith.GetComponent<Animation> ().Play ("Attack");
				lilith.GetComponent<Animation> ().Play ("Attack");
				GameObject fba = Instantiate (H2) as GameObject;
				GameObject fbb = Instantiate (H2) as GameObject;
				GameObject fbc = Instantiate (H2) as GameObject;
				GameObject fbd = Instantiate (H2) as GameObject;
				GameObject fbe = Instantiate (H2) as GameObject;


                fba.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fba.transform.rotation = lilith.transform.rotation;
                fba.gameObject.transform.Translate(new Vector3(-2.5f, 1.0f, 0.0f));


                fbb.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbb.transform.rotation = lilith.transform.rotation;
                fbb.gameObject.transform.Translate(new Vector3(0f, 1.0f, 0.0f));


                fbc.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbc.transform.rotation = lilith.transform.rotation;
                fbc.gameObject.transform.Translate(new Vector3(2.5f, 1.0f, 0.0f));


                fbd.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbd.transform.rotation = lilith.transform.rotation;
                fbd.gameObject.transform.Translate(new Vector3(5f, 1.0f, 0.0f));


                fbe.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbe.transform.rotation = lilith.transform.rotation;
                fbe.gameObject.transform.Translate(new Vector3(-5f, 1.0f, 0.0f));

                mana -= 15;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.Alpha3) && mana >= 30) { //Habilidade 3
				lilith.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H3) as GameObject;
				fb.transform.position = lilith.transform.position + (lilith.transform.forward);
				fb.transform.rotation = lilith.transform.rotation;
				fb.gameObject.transform.Translate (new Vector3 (0.0f, 0.05f, 5.0f));


                GameObject fba = Instantiate(T) as GameObject;
                GameObject fbb = Instantiate(T) as GameObject;
                GameObject fbc = Instantiate(T) as GameObject;
                GameObject fbd = Instantiate(T) as GameObject;
                GameObject fbe = Instantiate(T) as GameObject;
                GameObject fbf = Instantiate(T) as GameObject;
                GameObject fbg = Instantiate(T) as GameObject;
                GameObject fbh = Instantiate(T) as GameObject;
                GameObject fbi = Instantiate(T) as GameObject;

                fba.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fba.transform.rotation = lilith.transform.rotation;
                fba.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, 2.5f));

                fbb.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbb.transform.rotation = lilith.transform.rotation;
                fbb.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 2.5f));

                fbc.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbc.transform.rotation = lilith.transform.rotation;
                fbc.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, 2.5f));

                fbd.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbd.transform.rotation = lilith.transform.rotation;
                fbd.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, 5.0f));

                fbe.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbe.transform.rotation = lilith.transform.rotation;
                fbe.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 5.0f));

                fbf.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbf.transform.rotation = lilith.transform.rotation;
                fbf.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, 5.0f));

                fbg.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbg.transform.rotation = lilith.transform.rotation;
                fbg.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, 7.5f));

                fbh.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbh.transform.rotation = lilith.transform.rotation;
                fbh.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 7.5f));

                fbi.transform.position = lilith.transform.position + (lilith.transform.forward) * 2;
                fbi.transform.rotation = lilith.transform.rotation;
                fbi.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, 7.5f));


                mana -= 30;
				manaSlider.value = mana;
			}
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

	public void setAtive(bool a){
		ative = a;
	}

    public void resetPassos()
    {
        passos = 0;
    }
}