using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dano : MonoBehaviour {

	int vida = 60;
	public Slider healthSlider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(vida <= 0){
			this.gameObject.SetActive (false);
		}
	}

    public void somarvida(float vida)
    {
        vida = this.vida + vida;
    }

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Class 1"){
			vida -= 5;
			healthSlider.value = vida;
            Destroy(col.gameObject);
		}
		if(col.gameObject.tag == "Class 2"){
			vida -= 10;
			healthSlider.value = vida;
		}
		if(col.gameObject.tag == "Class 3"){
			vida -= 15;
			healthSlider.value = vida;
		}
		if(col.gameObject.tag == "Class 4"){
			vida -= 20;
			healthSlider.value = vida;
		}
		if(col.gameObject.tag == "Class 5"){
			vida -= 40;
			healthSlider.value = vida;
		}
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Life") {
			vida += 20;
			healthSlider.value = vida;
			Destroy (col.gameObject);
		}
	}

	public bool isDead(){
		if(vida <= 0){
			return true;
		}
		else{
			return false;
		}
	}
}
