﻿using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject[] Good;
    public Transform[] SPos;
    public float count = 0;

    float timer = 0;

    // Use this for initialization
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //if (count != 0)
        //{
        //    spawn();
        //}
        spawn();
    }


    void spawn()
    {

        timer += Time.deltaTime;
     
        if (timer >= 1)
        {
                Instantiate(Good[Random.Range(0, Good.Length)], SPos[Random.Range(0, SPos.Length)].position, Quaternion.identity);

            timer = 0;

        }

    }




}
