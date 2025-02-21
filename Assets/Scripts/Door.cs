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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            Debug.Log("Ouverture de la porte");
            animator.SetBool("isOpen", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            Debug.Log("Fermeture de la porte");
            animator.SetBool("isOpen", false);
        }
    }
}
