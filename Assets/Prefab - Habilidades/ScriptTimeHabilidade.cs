using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTimeHabilidade : MonoBehaviour {

    Vector3 posicao;

	void Start () {
		
	}
	
	void Update () {
        GameObject esfera = this.gameObject;

        if ((esfera.transform.position.z >= posicao.z + (4 * 2.5f)) || (esfera.transform.position.z <= posicao.z - (4 * 2.5f))
            || (esfera.transform.position.x >= posicao.x + (4 * 2.5f)) || (esfera.transform.position.x <= posicao.x - (4 * 2.5f)))
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "objeto")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Class 0")
        {
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }

    public void getPosicao(Vector3 posicao)
    {
        this.posicao = posicao;
    }
}
