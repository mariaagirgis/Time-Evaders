using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WALK : MonoBehaviour
{
    public float speed=35f;
    private new Rigidbody2D rigidbody;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right"))
        {
            transform.Translate(new Vector3(0.01f * speed, 0f, 0f));
            //anim.SetBool("WalkL", (true));
            //walk animation
        }
        else if (Input.GetKey("left"))
        {
            transform.Translate(new Vector3(-0.01f * speed, 0f, 0f));
            //anim.SetBool("WalkR", (true));
            //walk animation
        }
        else if (Input.GetKey("enter"))
        {
            //attack animation
            //anim.SetBool("Attack", (true));
        }
        else
        {
            //idle animation
            //anim.SetBool("Idle", (true));
        }
    }
}
