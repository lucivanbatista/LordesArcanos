using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aluria : MonoBehaviour {

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
        GameObject aluria = this.gameObject;
		if (ative) {
			if (Input.GetKeyDown (KeyCode.A)) {
				aluria.GetComponent<Animation> ().Play ("idle");
				aluria.transform.Rotate (new Vector3 (0.0f, -90.0f, 0.0f));
				H2.transform.rotation = aluria.transform.rotation;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				aluria.GetComponent<Animation> ().Play ("idle");
				aluria.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
				H2.transform.rotation = aluria.transform.rotation;
			} else if (Input.GetKeyDown (KeyCode.W)) {
				aluria.GetComponent<Animation> ().Play ("Walk");
				aluria.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
				H2.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
				passos++;
				Debug.Log ("Mana Atual: " + mana);
			} else if (Input.GetKeyDown (KeyCode.S)) {
				aluria.GetComponent<Animation> ().Play ("Walk");
				aluria.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
				H2.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.J) && mana >= 10) { //Habilidade 1
				aluria.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H1) as GameObject;
				fb.transform.position = aluria.transform.position + (aluria.transform.forward) * 2;
				fb.transform.position = (new Vector3 (fb.transform.position.x, 1.0f, fb.transform.position.z));
				fb.transform.rotation = aluria.transform.rotation;
				fb.GetComponent<MovimentoHabilidade> ().Direcao (aluria.transform.position);
				mana -= 10;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.K) && mana >= 15) { //Habilidade 2
				aluria.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H2) as GameObject;
				this.H2 = fb;
				fb.transform.position = aluria.transform.position;
				fb.gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, 0.5f));
				fb.transform.rotation = aluria.transform.rotation;
				mana -= 15;
				manaSlider.value = mana;
			
			} else if (Input.GetKeyDown (KeyCode.L) && mana >= 35) { //Habilidade 3
				aluria.GetComponent<Animation> ().Play ("Attack");
				GameObject fba = Instantiate (H3) as GameObject;
				GameObject fbb = Instantiate (H3) as GameObject;
				GameObject fbc = Instantiate (H3) as GameObject;

				fba.transform.position = aluria.transform.position + (aluria.transform.forward) * 2;
				fba.transform.rotation = aluria.transform.rotation;
				fba.gameObject.transform.Translate (new Vector3 (-2.5f, 1.0f, 0.0f));
            

				fbb.transform.position = aluria.transform.position + (aluria.transform.forward) * 2;
				fbb.transform.rotation = aluria.transform.rotation;
				fbb.gameObject.transform.Translate (new Vector3 (0f, 1.0f, 0.0f));
            

				fbc.transform.position = aluria.transform.position + (aluria.transform.forward) * 2;
				fbc.transform.rotation = aluria.transform.rotation;
				fbc.gameObject.transform.Translate (new Vector3 (2.5f, 1.0f, 0.0f));
            

				/*fba.transform.position = aluria.transform.position + (aluria.transform.forward) * 2;
            fba.transform.position = (new Vector3(aluria.transform.position.x , 1.0f, aluria.transform.position.z + 2.5f));
            fba.transform.rotation = aluria.transform.rotation;

            fbb.transform.position = aluria.transform.position + (aluria.transform.forward) * 2;
            fbb.transform.position = (new Vector3(aluria.transform.position.x, 1.0f, aluria.transform.position.z));
            fbb.transform.rotation = aluria.transform.rotation;

            fbc.transform.position = aluria.transform.position + (aluria.transform.forward) * 2;
            fbc.transform.position = (new Vector3(aluria.transform.position.x , 1.0f, aluria.transform.position.z - 2.5f));
            fbc.transform.rotation = aluria.transform.rotation;*/


				mana -= 35;
				manaSlider.value = mana;
			}
		}
        H2.transform.position = aluria.transform.position;
        H2.transform.Translate(new Vector3(0.0f, 0.5f, 0.0f));
        //n.transform.position = (new Vector3(n.transform.position.x + 0.5f , 1.0f, n.transform.position.z + 0.5f));
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
}