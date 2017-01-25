using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector3 newPos;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        newPos = transform.position;

        //

        transform.position = newPos;
    }
}
