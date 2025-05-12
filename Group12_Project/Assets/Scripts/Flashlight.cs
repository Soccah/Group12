using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
/// <summary>
/// Olivia Foster
/// 5/11/25
/// Flashlight turn on and off with 'F' key
/// </summary>

public class Flashlight : MonoBehaviour
{
    public GameObject ON;
    public GameObject OFF;
    private bool isON;

    public AudioSource toggleAudio;
    


    // Start is called before the first frame update
    void Start()
    {
        ON.SetActive(false);
        OFF.SetActive(true);
        isON = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(isON)
            {
                ON.SetActive(false);
                OFF.SetActive(true);
            }

            if(!isON)
            {
                ON.SetActive(true);
                OFF.SetActive(false);
            }

            isON = !isON;

            if (toggleAudio != null)
            {
                toggleAudio.Play();
            }
        }
    }

    
}
