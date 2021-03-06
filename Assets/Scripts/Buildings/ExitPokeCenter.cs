﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPokeCenter : MonoBehaviour
{
    GameObject player;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {

        //DontDestroyOnLoad(theManager);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {


        if (active && Input.GetButtonDown("Fire1"))
        {
            
            load("OverWorld");

            player.transform.position = new Vector3(-76, 13, 0);
            //DontDestroyOnLoad(player);
        }
        
    }

    public void load(string PlayerHome)
    {
        
        //SceneManager.LoadSceneAsync("OverWorld");
        SceneManager.UnloadSceneAsync("pokecenter_interior");
        

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            active = true;
            Debug.Log("active");
            
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            active = false;
        }
    }
}
