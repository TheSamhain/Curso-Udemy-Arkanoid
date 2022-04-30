using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
   
    private Rigidbody2D body;
    public BoxCollider2D col;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        body.constraints = new RigidbodyConstraints2D();
        col.isTrigger = true;
    }
}
