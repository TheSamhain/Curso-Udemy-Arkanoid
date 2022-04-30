using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    public int score = 0;
    private Text texto;

    void Start() {
        texto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update(){
        texto.text = score.ToString();
    }
}
