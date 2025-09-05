using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    

  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMove Pla = other.gameObject.GetComponent<PlayerMove>();
            if (Pla != null)
            {
                Pla.bruh();
             }
            Destroy(gameObject);
         }
    }
}
