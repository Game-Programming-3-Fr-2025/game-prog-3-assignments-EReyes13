using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D RB;

    public float Speed = 10;
    public bool IsSprinting;
    public float SprintDura = 5;

    public float mouseposx = 0;
    public float mouseposy = 0;
    public float Screenx = Screen.width;
    public float Screeny = Screen.height;
    // Update is called once per frame

    void Start()
    {
        Screenx = Screen.width;
        Screeny = Screen.height;
    }
    void Update()
    {
        Vector2 vel = RB.linearVelocity;
        Vector3 MousePos = Input.mousePosition;
        float midx = (Screenx / 2);
        float midy = (Screeny / 2);
        mouseposx = MousePos.x;
        mouseposy = MousePos.y;
        if (MousePos.x > midx)
        {
            vel.x = Speed;

        }
        else
        {
            vel.x = -Speed;

        }
        if (MousePos.y > midy)
        {
            vel.y = Speed;
        }
        else
        {
            vel.y = -Speed;
        }
        RB.linearVelocity = vel;
        //sprinting mechanic
        if (IsSprinting)
        {
            Speed = 15;
            SprintDura -= Time.deltaTime;
        }
        if (SprintDura <= 0.01f)
        {
            IsSprinting = false;
            SprintDura = 5;
            Speed = 10;
         }
    }

    public void runnin()
    {
        IsSprinting = true;
        SprintDura = 5;
     }
}
