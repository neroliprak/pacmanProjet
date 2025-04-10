using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Open the door if the player enters
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            animator.SetBool("isOpen", true);
        }
    }

    // Close the door if the player exits
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            animator.SetBool("isOpen", false);
        }
    }
}
