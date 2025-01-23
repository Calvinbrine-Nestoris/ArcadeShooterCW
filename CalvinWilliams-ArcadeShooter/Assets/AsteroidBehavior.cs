using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = -1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed += (Time.deltaTime * -0.02f);
        rb.velocity = new Vector2(0, speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ResetBarrier"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 30);
        }
        if (collision.CompareTag("Laser"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 30);
        }
    }
}
