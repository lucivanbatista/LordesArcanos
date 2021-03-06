﻿using UnityEngine;
using UnityEngine.UI;

public class Rayssa : MonoBehaviour {

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
		GameObject rayssa = this.gameObject;
		if (ative) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				rayssa.GetComponent<Animation> ().Play ("idle");
				rayssa.transform.Rotate (new Vector3 (0.0f, -90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				rayssa.GetComponent<Animation> ().Play ("idle");
				rayssa.transform.Rotate (new Vector3 (0.0f, 90.0f, 0.0f));
			} else if (Input.GetKeyDown (KeyCode.UpArrow) && passos < limitePassos) {
				rayssa.GetComponent<Animation> ().Play ("Walk");
				rayssa.transform.Translate (new Vector3 (0.0f, 0.0f, 2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.DownArrow) && passos < limitePassos) {
				rayssa.GetComponent<Animation> ().Play ("Walk");
				rayssa.transform.Translate (new Vector3 (0.0f, 0.0f, -2.5f));
				passos++;
			} else if (Input.GetKeyDown (KeyCode.B) && mana >= 20) { //Habilidade 1
				rayssa.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H1) as GameObject;
				fb.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
				fb.gameObject.transform.Translate (new Vector3 (0.0f, 1.0f, 0.0f));
				fb.transform.rotation = rayssa.transform.rotation;
				fb.GetComponent<Rigidbody> ().AddForce (fb.transform.forward * 500.0f);

				fb.GetComponent<ScriptTimeHabilidade> ().getPosicao (rayssa.transform.position);
				mana -= 20;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.N) && mana >= 5) { //Habilidade 2
				rayssa.GetComponent<Animation> ().Play ("Attack");
				GameObject fb = Instantiate (H2) as GameObject;
				fb.transform.position = rayssa.transform.position;
            
				passos -= 2;
				mana -= 5;
				manaSlider.value = mana;
			} else if (Input.GetKeyDown (KeyCode.M) && mana >= 35) { //Habilidade 3
				rayssa.GetComponent<Animation> ().Play ("Attack");

                GameObject fba = Instantiate(H3) as GameObject;
                GameObject fbb = Instantiate(H3) as GameObject;
                GameObject fbc = Instantiate(H3) as GameObject;
                GameObject fbd = Instantiate(H3) as GameObject;
                GameObject fbe = Instantiate(H3) as GameObject;
                GameObject fbf = Instantiate(H3) as GameObject;
                GameObject fbg = Instantiate(H3) as GameObject;
                GameObject fbh = Instantiate(H3) as GameObject;
                GameObject fbi = Instantiate(H3) as GameObject;

                fba.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fba.transform.rotation = rayssa.transform.rotation;
                fba.gameObject.transform.Translate(new Vector3(0f, 0.05f, -5f));

                fbb.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fbb.transform.rotation = rayssa.transform.rotation;
                fbb.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, -2.5f));

                fbc.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fbc.transform.rotation = rayssa.transform.rotation;
                fbc.gameObject.transform.Translate(new Vector3(-5f, 0.05f, 0f));

                fbd.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fbd.transform.rotation = rayssa.transform.rotation;
                fbd.gameObject.transform.Translate(new Vector3(-2.5f, 0.05f, 2.5f));

                fbe.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fbe.transform.rotation = rayssa.transform.rotation;
                fbe.gameObject.transform.Translate(new Vector3(0.0f, 0.05f, 5f));

                fbf.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fbf.transform.rotation = rayssa.transform.rotation;
                fbf.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, 2.5f));

                fbg.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fbg.transform.rotation = rayssa.transform.rotation;
                fbg.gameObject.transform.Translate(new Vector3(5f, 0.05f, 0f));

                fbh.transform.position = rayssa.transform.position + (rayssa.transform.forward) * 2;
                fbh.transform.rotation = rayssa.transform.rotation;
                fbh.gameObject.transform.Translate(new Vector3(2.5f, 0.05f, -2.5f));


                //GameObject fb1 = Instantiate (H3) as GameObject;

                /*GameObject fb4 = Instantiate(H3) as GameObject;
            GameObject fb5 = Instantiate(H3) as GameObject;
            GameObject fb6 = Instantiate(H3) as GameObject;
            GameObject fb7 = Instantiate(H3) as GameObject;
            GameObject fb8 = Instantiate(H3) as GameObject;
            GameObject fb9 = Instantiate(H3) as GameObject;*/

                //fb1.transform.position = rayssa.transform.position;

                /*fb4.transform.position = rayssa.transform.position;
            fb5.transform.position = rayssa.transform.position;
            fb6.transform.position = rayssa.transform.position;
            fb7.transform.position = rayssa.transform.position;
            fb8.transform.position = rayssa.transform.position;
            fb9.transform.position = rayssa.transform.position;*/

                //fb1.gameObject.transform.Translate (new Vector3 (10.0f, 0.05f, 0.0f));

                /*fb4.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb5.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb6.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb7.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb8.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));
            fb9.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.5f));*/


                mana -= 35;
				manaSlider.value = mana;
			}
        
			//Comando para limitar o plano (Não sair do plano)
			Vector3 pos = rayssa.transform.position;
			rayssa.transform.position = new Vector3 (Mathf.Clamp (pos.x, 1.25f, 48.75f), pos.y, Mathf.Clamp (pos.z, 1.25f, 48.75f));
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