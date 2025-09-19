using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {


    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Toucher"))
        {
            Gamemanager.Score++;
            PlayerMovement SP = other.gameObject.GetComponent<PlayerMovement>();
            if (SP != null)
            {
                SP.runnin();
            }
            Destroy(gameObject);
         }
    }
}

