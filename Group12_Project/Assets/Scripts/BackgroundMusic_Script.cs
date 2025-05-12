using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Olivia Foster
/// 5/11/25
/// Plays background music during all scenes
/// </summary>

public class BackgroundMusic_Script : MonoBehaviour
{
    public static BackgroundMusic_Script instance;

    private void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
