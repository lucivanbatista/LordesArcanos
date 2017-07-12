using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tarir : MonoBehaviour {

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
		GameObject tarir = this.gameObject;
		if (ative) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				tarir.GetComponent<Animation> ().Play ("idle");
				tarir.transform.Rotate (new Vector3 (0.0f, -90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				tarir.GetComponent<Animation> ().Play ("idle");
				tarir.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
				tarir.GetComponent<Animation> ().Play ("Walk");
				tarir.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				tarir.GetComponent<Animation> ().Play ("Walk");
				tarir.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.B) && mana >= 10) { //Habilidade 1
				tarir.GetComponent<Animation> ().Play ("Attack");
				GameObject fba = Instantiate (H1) as GameObject;
				GameObject fbb = Instantiate (H1) as GameObject;
				GameObject fbc = Instantiate (H1) as GameObject;
				GameObject fbd = Instantiate (H1) as GameObject;
				GameObject fbe = Instantiate (H1) as GameObject;
				GameObject fbf = Instantiate (H1) as GameObject;
				GameObject fbg = Instantiate (H1) as GameObject;
				GameObject fbh = Instantiate (H1) as GameObject;
				GameObject fbi = Instantiate (H1) as GameObject;

				fba.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fba.transform.rotation = tarir.transform.rotation;
				fba.gameObject.transform.Translate (new Vector3 (2.5f, 0.05f, 2.5f));

				fbb.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbb.transform.rotation = tarir.transform.rotation;
				fbb.gameObject.transform.Translate (new Vector3 (0.0f, 0.05f, 2.5f));

				fbc.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbc.transform.rotation = tarir.transform.rotation;
				fbc.gameObject.transform.Translate (new Vector3 (-2.5f, 0.05f, 2.5f));

				fbd.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbd.transform.rotation = tarir.transform.rotation;
				fbd.gameObject.transform.Translate (new Vector3 (2.5f, 0.05f, 5.0f));

				fbe.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbe.transform.rotation = tarir.transform.rotation;
				fbe.gameObject.transform.Translate (new Vector3 (0.0f, 0.05f, 5.0f));

				fbf.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbf.transform.rotation = tarir.transform.rotation;
				fbf.gameObject.transform.Translate (new Vector3 (-2.5f, 0.05f, 5.0f));

				fbg.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbg.transform.rotation = tarir.transform.rotation;
				fbg.gameObject.transform.Translate (new Vector3 (2.5f, 0.05f, 7.5f));

				fbh.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbh.transform.rotation = tarir.transform.rotation;
				fbh.gameObject.transform.Translate (new Vector3 (0.0f, 0.05f, 7.5f));

				fbi.transform.position = tarir.transform.position + (tarir.transform.forward) * 2;
				fbi.transform.rotation = tarir.transform.rotation;
				fbi.gameObject.transform.Translate (new Vector3 (-2.5f, 0.05f, 7.5f));

				//fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
				mana -= 10;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.N) && mana >= 10) { //Habilidade 2
				tarir.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H2) as GameObject;
				fb.transform.position = new Vector3 (20.0f, 0.05f, 20.0f);
				/*if (gameObject.tag == "Player")
            {
                Debug.Log("Entrou");
                gameObject.tag += 20;
            }*/
				mana -= 10;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.M) && mana >= 20) { //Habilidade 3
				tarir.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H3) as GameObject;
				fb.transform.position = new Vector3 (20.0f, 2.0f, 25.0f);
				mana -= 20;
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
}