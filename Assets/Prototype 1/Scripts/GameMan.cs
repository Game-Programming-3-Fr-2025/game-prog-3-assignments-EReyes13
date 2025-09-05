using System;
using TMPro;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class GameMan : MonoBehaviour
{

   
    public float WaterLevel = 100;
    public GameObject wata;
    public GameObject Base;

    public TextMeshProUGUI stat;

    Vector3[] spawns = new Vector3[6];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int indexertype = UnityEngine.Random.Range(0, 5);
        spawns[0] = new Vector3(-45, 10, 0);
        spawns[1] = new Vector3(-33, 5.5f, 0);
        spawns[2] = new Vector3(-23, 2, 0);
        spawns[3] = new Vector3(10, 10, 0);
        spawns[4] = new Vector3(26, 9, 0);
        spawns[5] = new Vector3(48, 7, 0);
        Instantiate(wata, spawns[indexertype], Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        WaterLevel -= Time.deltaTime;
        stat.text = ("Water Left: " + WaterLevel.ToString("F0") +("%"));
        if (WaterLevel <= 0)
        {
            EditorApplication.ExitPlaymode();
         }
    }
    public void Again()
    {
        int indexertype = UnityEngine.Random.Range(0, 5);
        Instantiate(wata, spawns[indexertype],Quaternion.identity);
     }
   
}
