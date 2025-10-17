using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public SpriteRenderer SR;
    public Rigidbody2D RB;

    public bool Floored;

    public float Speed = 5;
    public float JumpPower = 10;
    public float Gravity = 3;

    public bool moving;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(1, 0, 0), new Vector2(1, 0), 3);
                if (hit)
                {
                   // Debug.Log("I hit" + hit.transform.tag);
                   Enemy LTG = hit.transform.GetComponent<Enemy>();
                    {
                        if (LTG != null)
                        {
                            LTG.Youngman();
                        }

                    }
                    /* if(hit.transform.CompareTag("Toucher"))
                    {
                        Debug.Log("hit");
                    }*/
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(-1, 0, 0), new Vector2(-1, 0), 3);
                if (hit)
                {
                    // Debug.Log("I hit" + hit.transform.tag);
                    Enemy LTG = hit.transform.GetComponent<Enemy>();
                    {
                        if (LTG != null)
                        {
                            LTG.Youngman();
                        }
                    }
                    /* if(hit.transform.CompareTag("Toucher"))
                    {
                        Debug.Log("hit");
                    }*/
                }
            }
            else
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(1, 0, 0), new Vector2(1, 0), 3); 
                if (hit)
                {
                    //Debug.Log("I hit" + hit.transform.tag);
                    Enemy LTG = hit.transform.GetComponent<Enemy>();
                    {
                        if (LTG != null)
                        {
                            LTG.Youngman();
                        }
                    }
                   /* if(hit.transform.CompareTag("Toucher"))
                    {
                        Debug.Log("hit");
                    }*/
                }
            }
            
            
        }


        Vector2 vel = RB.linearVelocity;

        if (moving)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {

                vel.x = Speed;



            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {

                vel.x = -Speed;



            }
            else
            {
                vel.x = 0;
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Floored)
                {
                    vel.y = JumpPower;
                }
            }
        }
        RB.linearVelocity = vel;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ice"))
        {
            moving = false;
            RB.linearVelocityY = (-5f);

        }
        /*if (other.gameObject.CompareTag("Floor"))
        {
            moving = true;
            Floored = true;
        }*/
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        Floored = false;
    }

    public void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            moving = true;
            Floored = true;
        }
    }
}

