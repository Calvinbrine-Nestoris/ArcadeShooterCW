using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShot : MonoBehaviour
{
    Rigidbody2D rb;
    public AudioSource destroySound;
    public AudioSource laserShot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            
            Destroy(gameObject);
            destroySound.Play();
        }
        if (collision.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }

    }
}
