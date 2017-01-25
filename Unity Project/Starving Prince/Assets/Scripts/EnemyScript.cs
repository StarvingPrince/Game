using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    Vector3 newPos;
    GameObject player;

    public float speed = 1;
    public int maxHealth = 100;
    public int health = 100;

    float angle = 0;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Princess");
    }
	
	// Update is called once per frame
	void Update () {
        newPos = transform.position;

        float dz = player.transform.position.z - newPos.z;
        float dx = player.transform.position.x - newPos.x;

        angle = Mathf.Atan2(dz, dx);

        newPos.x += Mathf.Cos(angle)*speed;
        newPos.z += Mathf.Sin(angle)*speed;

        transform.position = newPos;
    }

    
}
