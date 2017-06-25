using UnityEngine;
using System.Collections;

public class LifePotionScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Life") {
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "Mana") {
			Destroy (other.gameObject);
		}
	}
	// Update is called once per frame
	void Update (){

	}
}

