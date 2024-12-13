using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowPlayer : MonoBehaviour
{

    public float speed = 0.02f;
    public int minDistance = 0;


    private Transform playerTransform;

    private const string PLAYER_TAG = "Player";
    public void StartGame()
    {
        Debug.Log("START");
    }
    void Start()
    {
        // Player est tag ?
        GameObject player = GameObject.FindGameObjectWithTag(PLAYER_TAG);

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
