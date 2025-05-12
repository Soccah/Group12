using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Olivia Foster
/// 5/11/25
/// Flickers lightbulb with invokerepeating
/// </summary>

public class FlickerLight : MonoBehaviour
{
        public Light theLight;
        public float repeatRate = 0.5f; // How often to toggle (seconds)
        public AudioSource lightOnAudio;
        

        void Start()
        {
            InvokeRepeating("ToggleLight", 0f, repeatRate);
        }

        void ToggleLight()
        {
            if (theLight != null)
            {
                theLight.enabled = !theLight.enabled;

                if(theLight.enabled && lightOnAudio != null)
                {
                    lightOnAudio.Play();
                }
            
            }

        }

        void OnDisable()
        {
            CancelInvoke(); // Stop flickering when the script is disabled
        }
}
