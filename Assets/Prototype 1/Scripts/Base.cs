using UnityEngine;

public class Base : MonoBehaviour
{
    public bool water;
    public GameObject bos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (water)
            {
                GameMan gam = bos.gameObject.GetComponent<GameMan>();
                if (gam != null)
                {
                    gam.WaterLevel = 100;
                    water = false;
                    gam.Again();
                }
            }


        }
    }
    public void Shika()
    {
        water = true;
     }
   
}
