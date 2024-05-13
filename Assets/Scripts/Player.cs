using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float JumpForce = 3;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.PlayerVivo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.velocity = Vector3.zero;
            Rigidbody.AddForce(new Vector2(0, JumpForce));
            Rigidbody.constraints = RigidbodyConstraints2D.None;
            if(audioSource.clip != null)
            {
                audioSource.Play();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("dano"))
        {
            Destroy(this.gameObject);
            GameManager.Instance.KillPlayer();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("dano"))
        {
            Destroy(this.gameObject);
            GameManager.Instance.KillPlayer();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ponto"))
        {
            GameManager.Instance.Score++;
        }


        
    }
}
