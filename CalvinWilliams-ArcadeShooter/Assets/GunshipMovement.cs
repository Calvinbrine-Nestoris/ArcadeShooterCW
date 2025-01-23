using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public GameObject projectile;
    float speed = 0f;
    float reset = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            speed -= 5;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            speed += 5;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) == true)
        {
            speed += 5;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) == true)
        {
            speed -= 5;
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && reset >= 1)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            reset = 0.1f;
        }
        if (reset < 1)
        {
            reset += Time.deltaTime;
        }
    }
}
