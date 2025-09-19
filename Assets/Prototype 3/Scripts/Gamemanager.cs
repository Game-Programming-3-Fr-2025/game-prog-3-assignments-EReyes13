using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public float Spawncool = 0;
    public static int Score = 0;
    public float Timer = 60;
    public TextMeshProUGUI Timetext;
    public TextMeshProUGUI Scoretext;
    public GameObject Letoucher;
    public bool playing;



    // Update is called once per frame

    void Start()
    {
        Spawncool = UnityEngine.Random.Range(3f, 6f);
        playing = true;
    }
    void Update()
    {
       
        Timetext.text = ("Time:" + Timer.ToString("F0"));
        Scoretext.text = ("Score:" + Score); 
        if (playing)
        {
            Timer -= Time.deltaTime;
            Spawncool -= Time.deltaTime;
            if (Spawncool <= 0.01f)
            {
                 
                Instantiate(Letoucher, new Vector3((UnityEngine.Random.Range(-35, 27)), ((UnityEngine.Random.Range(-25, 37))), 0f), Quaternion.identity);
                Spawncool = UnityEngine.Random.Range(3f, 6f);
            }
        }
        if (Timer <= 0.01f)
        {
            playing = false;
         }
       
    }
}
