using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Olivia Foster
/// 5/12/25
/// Opens the door in regard to my previous Interactable script
/// </summary>

public class Door : MonoBehaviour, IInteractable
{
    public GameObject door;            // The door GameObject
    public Transform doorHinge;        // The Empty GameObject (acting as the pivot)
    public float openAngle = -90f;      // How far to rotate the door
    public float openSpeed = 2f;       // Speed of opening/closing

    private bool isOpen = false;

    public AudioSource doorAudio;
    public AudioClip doorOpenSound;

    void Start()
    {
        //Ensures the door starts closed
        doorHinge.rotation = Quaternion.Euler(0, 180f, 0);
    }

    public void Interact()
    {
        isOpen = !isOpen;
        StopAllCoroutines();
        StartCoroutine(RotateDoor());
    }

    IEnumerator RotateDoor()
    {
        if (doorAudio != null && doorOpenSound != null)
        {
            doorAudio.PlayOneShot(doorOpenSound);
        }

        
        float baseY = 180f;
        float targetY = isOpen ? baseY + openAngle : baseY;
        Quaternion targetRotation = Quaternion.Euler(0, targetY, 0);

        float elapsedTime = 0f;
        Quaternion initialRotation = doorHinge.rotation;

        while (elapsedTime < openSpeed)
        {
            doorHinge.rotation = Quaternion.Slerp(initialRotation, targetRotation, elapsedTime / openSpeed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        doorHinge.rotation = targetRotation;
    }
}
