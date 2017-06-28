using UnityEngine;
using System.Collections;

public class LifePotionScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update (){

	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Life")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Mana")
        {
            Destroy(col.gameObject);
        }
    }
}

