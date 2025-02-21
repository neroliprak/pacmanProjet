using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowPlayer : MonoBehaviour
{

    // ---- Définition de la variable vitesse
    public float speed = 0.02f;


    // ---- Je récupère les positions du player
    private Transform playerTransform;

    // ---- Je recupère le Player grâce à son Tag
    private const string PLAYER_TAG = "Player";
    public void StartGame()
    {
        Debug.Log("START");
    }
    void Start()
    {
        // ---- Je cherche le player avec le tag player
        GameObject player = GameObject.FindGameObjectWithTag(PLAYER_TAG);

        // ---- Si je trouve pas le tag player
        if (player != null)
        {
            playerTransform = player.transform;
        }

    }

    void Update()
    {
        if (playerTransform != null)
        {
            float distance = Vector3.Distance(this.transform.position, playerTransform.position);

            Vector3 direction = (playerTransform.position - this.transform.position);
            this.transform.position += direction * speed * Time.deltaTime;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == PLAYER_TAG)
        {
            Debug.Log("TOUCHER !");
        }
    }

}
