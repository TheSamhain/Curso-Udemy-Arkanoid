using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 10.0f;
    public float horizontalAxis;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        horizontalAxis = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(velocidade * horizontalAxis, 0);
    }
}
