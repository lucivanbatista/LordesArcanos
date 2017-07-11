using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBoladeFogo : MonoBehaviour {

    Vector3 posicaoInicial;
    float tempo;

    void Start () {
        posicaoInicial = this.gameObject.transform.position;
        tempo = Time.fixedTime;
    }

	void Update () {
        if ((Time.fixedTime - tempo) > 0.35)
        { // Tempo controla a particula de collider que dá dano
            Debug.Log(tempo + ";" + Time.fixedTime);
            Destroy(this.gameObject);
        }
    }
}