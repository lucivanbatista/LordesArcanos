using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoHabilidade : MonoBehaviour {

    float tempo;
    Vector3 posicao;

    // Use this for initialization
    void Start() {
        tempo = Time.fixedTime;
    }

    // Update is called once per frame
    void Update() {
        
        if ((Time.fixedTime - tempo) > 2) { // Tempo controla a particula de collider que dá dano
            Destroy(this.gameObject);
        }
        
        //Debug.Log(this.gameObject.transform.position.x + ";" + this.gameObject.transform.position.y + ";" + this.gameObject.transform.position.z);
        this.gameObject.transform.Translate(0.0f, 0.0f, 0.07f);

    }

    public void Direcao(Vector3 v3){
        this.posicao = v3;
    }
}