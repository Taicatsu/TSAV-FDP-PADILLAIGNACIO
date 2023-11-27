using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    public AudioSource turnOn;
    public AudioSource turnOff;

    public bool on;
    public bool off;

    void Start()
    {
        off = true;
        flashlight.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        if(off && Input.GetKeyDown(KeyCode.F))
        { 
            flashlight.SetActive(true);
            turnOn.Play(); 
            off = false;
            on = true;
            Debug.Log("FLASHon");
        }
        else if (on && Input.GetKeyDown(KeyCode.F))
        {
            flashlight.SetActive(false);
            turnOff.Play();
            off = true;
            on = false;
            Debug.Log("FLASHoff");
        }      
    }
}
