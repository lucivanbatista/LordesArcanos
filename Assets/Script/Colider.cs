using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour {

    Vector3 pos_atual;

    void Start () {
        pos_atual = this.gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        pos_atual = this.gameObject.transform.position;

        //Comando para limitar o plano (Não sair do plano)
        Vector3 pos = this.gameObject.transform.position;
        this.gameObject.transform.position = new Vector3(Mathf.Clamp(pos.x, 1.25f, 48.75f), pos.y, Mathf.Clamp(pos.z, 1.25f, 48.75f));
    }

    void OnCollisionEnter(Collision col)
    {
        this.gameObject.transform.position = pos_atual;
    }

}
