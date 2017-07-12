using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoHabilidadeParado : MonoBehaviour {

    float tempo;
    Vector3 posicao;

    void Start () {
        tempo = Time.fixedTime;
    }
	
	
	void Update () {
        if ((Time.fixedTime - tempo) > 5)
        { // Tempo controla a particula de collider que dá dano
            Destroy(this.gameObject);
        }

    }    
}