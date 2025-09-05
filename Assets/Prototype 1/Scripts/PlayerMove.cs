using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D RB;

    public bool Floored;

    public bool CactusJack;
    public GameObject Home;

    public float Speed = 5;
    public float JumpPower = 10;
    public float Gravity = 3;
    public float Countdown = 5;
    // Update is called once per frame
    void Update()
    {
        Vector2 vel = RB.linearVelocity;


        if (Input.GetKey(KeyCode.RightArrow))
        {
            //If I hit right, move right
            vel.x = Speed;
            //If I hit right, mark that I'm not facing left


        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //If I hit left, move right
            vel.x = -Speed;
            //If I hit left, mark that I'm facing left


        }
        else
        {  //If I hit neither, come to a stop
            vel.x = 0;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Floored)
            {
                vel.y = JumpPower;
            }
        }
        RB.linearVelocity = vel;

        if (CactusJack)
        {
            Speed = 2;
            JumpPower = 6;
            Countdown -= Time.deltaTime;
        }
        if (Countdown <= 0.01f)
        {
            CactusJack = false;
            Countdown = 5;
            Speed = 5;
            JumpPower = 10;
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Floored = true;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        Floored = false;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cactus"))
        {
            CactusJack = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {

    }
    public void bruh()
    { 
        Base bas = Home.gameObject.GetComponent<Base>();
            if (bas != null)
            {
                
                bas.Shika();
             }  
    }
}
