using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    SpriteRenderer sprite;
    bool faceright =true;

    public GameObject bullet;
    GameObject bulletclone;
    public float speed;
    public Transform leftspawn;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        flipplayer();
        fire();
    }


    void flipplayer()
    {
        if(Input.GetKeyDown(KeyCode.D)&& faceright == false)
        {
            sprite.flipX = false;
            faceright = true;
        }
        if (Input.GetKeyDown(KeyCode.A) && faceright == true )
        {
            sprite.flipX = true ;
            faceright = false ;
        }
    }

    void fire()
    {
        if (Input.GetMouseButtonDown(0)&& faceright)
        {
            bulletclone = Instantiate(bullet, transform.position, transform.rotation);
            bulletclone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            Destroy(bulletclone, 1.5f);
        }
        else if (Input.GetMouseButtonDown(0) && !faceright)
        {
            bulletclone = Instantiate(bullet, leftspawn .position, leftspawn .rotation);
            bulletclone.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            Destroy(bulletclone, 1.5f);
        }
    }
}
