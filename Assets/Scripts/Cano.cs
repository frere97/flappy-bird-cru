using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Cano : MonoBehaviour
{
    public float velocidade = -1f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = new Vector2(velocidade, 0);
        if(transform.position.x < -40)
        {
            Destroy(this.gameObject);
        }
    }

}
