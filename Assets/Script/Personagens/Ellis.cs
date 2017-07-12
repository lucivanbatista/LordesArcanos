using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ellis : MonoBehaviour {

	public GameObject H1;
	public GameObject H2;
	public GameObject H3;
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
		GameObject ellis = this.gameObject;
		if (ative) {
			if (Input.GetKeyDown (KeyCode.A)) {
				ellis.GetComponent<Animation> ().Play ("idle");
				ellis.transform.Rotate (new Vector3 (0.0f, -90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.D)) {
				ellis.GetComponent<Animation> ().Play ("idle");
				ellis.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.W) && passos < limitePassos) {
				ellis.GetComponent<Animation> ().Play ("Walk");
				ellis.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.S) && passos < limitePassos) {
				ellis.GetComponent<Animation> ().Play ("Walk");
				ellis.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.Alpha1) && mana >= 20) { //Habilidade 1
				ellis.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H1) as GameObject;

                fb.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fb.gameObject.transform.Translate(new Vector3(0.0f, 1.0f, 0.0f));
                fb.transform.rotation = ellis.transform.rotation;
                fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);

                fb.GetComponent<ScriptTimeHabilidade>().getPosicao(ellis.transform.position);

                mana -= 20;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.Alpha2) && mana >= 25) { //Habilidade 2
				ellis.GetComponent<Animation> ().Play ("Attack");
                GameObject fba = Instantiate(H2) as GameObject;
                GameObject fbb = Instantiate(H2) as GameObject;
                GameObject fbc = Instantiate(H2) as GameObject;

                fba.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fba.transform.rotation = ellis.transform.rotation;
                fba.gameObject.transform.Translate(new Vector3(-2.5f, 1.0f, 0.0f));


                fbb.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbb.transform.rotation = ellis.transform.rotation;
                fbb.gameObject.transform.Translate(new Vector3(0f, 1.0f, 0.0f));


                fbc.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbc.transform.rotation = ellis.transform.rotation;
                fbc.gameObject.transform.Translate(new Vector3(2.5f, 1.0f, 0.0f));

                mana -= 25;
				manaSlider.value = mana;

			} else if (Input.GetKeyDown (KeyCode.Alpha3) && mana >= 30) { //Habilidade 3
				ellis.GetComponent<Animation> ().Play ("Attack");

                GameObject fba = Instantiate(H3) as GameObject;
                GameObject fbb = Instantiate(H3) as GameObject;
                GameObject fbc = Instantiate(H3) as GameObject;
                GameObject fbd = Instantiate(H3) as GameObject;
                GameObject fbe = Instantiate(H3) as GameObject;
                GameObject fbf = Instantiate(H3) as GameObject;
                GameObject fbg = Instantiate(H3) as GameObject;
                GameObject fbh = Instantiate(H3) as GameObject;
                GameObject fbi = Instantiate(H3) as GameObject;

                fba.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fba.transform.rotation = ellis.transform.rotation;
                fba.gameObject.transform.Translate(new Vector3(0f, 0.05f, -5f));

                fbb.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbb.transform.rotation = ellis.transform.rotation;
                fbb.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, -2.5f));

                fbc.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbc.transform.rotation = ellis.transform.rotation;
                fbc.gameObject.transform.Translate(new Vector3(-5f, 0.05f, 0f));

                fbd.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbd.transform.rotation = ellis.transform.rotation;
                fbd.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, 2.5f));

                fbe.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbe.transform.rotation = ellis.transform.rotation;
                fbe.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 5f));

                fbf.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbf.transform.rotation = ellis.transform.rotation;
                fbf.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, 2.5f));
            
                fbg.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbg.transform.rotation = ellis.transform.rotation;
                fbg.gameObject.transform.Translate(new Vector3(5f, 0.05f, 0f));

                fbh.transform.position = ellis.transform.position + (ellis.transform.forward) * 2;
                fbh.transform.rotation = ellis.transform.rotation;
                fbh.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, -2.5f));

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