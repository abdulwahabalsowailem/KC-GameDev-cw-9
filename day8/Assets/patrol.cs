using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public Transform groundpos;
    public float speed;
    public LayerMask groundlayer;
    public float rad;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemypetrol();
    }

    void enemypetrol()
    {
        rb.velocity = new Vector2(speed, 0f);
        bool isgrounded = Physics2D.OverlapCircle(groundpos.position, rad, groundlayer);

        if(!isgrounded)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            speed *= -1;
        }
    }
}
