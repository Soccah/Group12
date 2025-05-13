using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jumpscare : MonoBehaviour
{
    public GameObject Monster;
    public AudioSource JumpscareSound;
    public float destroyDelay = 1f;
    public float monsterDisappearDelay = 1f;
    public int damageAmount = 2; // How much health the player loses

    void Start()
    {
        if (Monster != null)
            Monster.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate the monster and play sound
            if (Monster != null)
                Monster.SetActive(true);

            if (JumpscareSound != null)
                JumpscareSound.Play();

            // Deal damage to the player
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }

            // Start the delay before hiding the monster and destroying the trigger
            StartCoroutine(DestroyTriggerAndHideMonsterAfterDelay(monsterDisappearDelay));
        }
    }

    private IEnumerator DestroyTriggerAndHideMonsterAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (Monster != null)
            Monster.SetActive(false);

        Destroy(gameObject);
    }
}
