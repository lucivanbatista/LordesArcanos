using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kane : MonoBehaviour {

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
		GameObject kane = this.gameObject;
		
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            kane.GetComponent<Animation>().Play("idle");
            kane.transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            kane.GetComponent<Animation>().Play("idle");
            kane.transform.Rotate(new Vector3(0.0f, 90.0f, 0.0f));
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            kane.GetComponent<Animation>().Play("Walk");
            kane.transform.Translate(new Vector3(0.0f, 0.0f, 2.5f));
            passos++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            kane.GetComponent<Animation>().Play("Walk");
            kane.transform.Translate(new Vector3(0.0f, 0.0f, -2.5f));
            passos++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && mana >= 15)        { //Habilidade 1
            kane.GetComponent<Animation>().Play("Attack");
            GameObject fb = Instantiate(H1) as GameObject;
            fb.transform.position = kane.transform.position + (kane.transform.forward) * 2;
            fb.gameObject.transform.Translate(new Vector3(-0.5f, 1.0f, 0.0f));
            fb.transform.rotation = kane.transform.rotation;
            //fb.GetComponent<Rigidbody>().AddForce(fb.transform.forward * 500.0f);
            mana -= 15;
			manaSlider.value = mana;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && mana >= 15)
        { //Habilidade 2
            kane.GetComponent<Animation>().Play("Attack");
            GameObject fb = Instantiate(H2) as GameObject;
            fb.transform.position = kane.transform.position + (kane.transform.forward);
            fb.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.0f));
            fb.transform.rotation = kane.transform.rotation;
            mana -= 15;
			manaSlider.value = mana;

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && mana >= 35)
        { //Habilidade 3
            kane.GetComponent<Animation>().Play("Attack");
            GameObject fb = Instantiate(H3) as GameObject;
            fb.transform.position = kane.transform.position + (kane.transform.forward);
            fb.gameObject.transform.Translate(new Vector3(-1.25f, 0.05f, 2.0f));
            fb.transform.rotation = kane.transform.rotation;
            mana -= 35;
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