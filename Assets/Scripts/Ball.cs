using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    /*
    public Vector2 velocidade;
    private Rigidbody2D rigidbody;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(velocidade);
    }
    */

    public float speed = 5f;
    private Rigidbody2D body;

    void Start(){
        body = GetComponent<Rigidbody2D>();
        body.velocity = Vector2.up * speed;
    }

    float HitFactor(Vector2 ball, Vector2 player, float playerWidth){
        return (ball.x - player.x) / playerWidth;
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Player"){
            float x = HitFactor(
                transform.position,
                col.transform.position,
                col.collider.bounds.size.x
            );

            Vector2 dir = new Vector2(x, 1).normalized;

            body.velocity = dir * speed;            
        }
    }

}
