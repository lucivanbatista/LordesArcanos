using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision col)
	{
		

		if(col.gameObject.tag == "Class 1" || col.gameObject.tag == "Class 2" || col.gameObject.tag == "Class 3" || col.gameObject.tag == "Class 4" || col.gameObject.tag == "Class 5")
		{
			Destroy(col.gameObject);
            if(this.gameObject.tag == "Class 0")
            {
                Destroy(this.gameObject);
            }
		}
        
	}
}
