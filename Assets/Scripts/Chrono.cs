using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chrono : MonoBehaviour
{
    public float chronometre;

    // Start is called before the first frame update
    void Start()
    {
        chronometre = 0;
    }

    // Update is called once per frame
    void Update()
    {
        chronometre = chronometre - Time.deltaTime;
        // Debug.Log(chronometre);
    }
}
