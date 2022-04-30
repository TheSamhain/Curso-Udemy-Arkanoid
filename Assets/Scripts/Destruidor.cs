using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour
{
    private GameObject col;
    public Pontos PontosObj;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        col = collision.collider.gameObject;

        if (col.tag == "Ball")
        {
            GameObject.Destroy(col);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        PontosObj.score += 10;
        GameObject.Destroy(col.gameObject);
    }
}
