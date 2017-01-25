using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessScript : MonoBehaviour {
    Vector3 newPos;
    GameObject player;

    public bool captured = false;
    public string team = "Blue";

    float angle;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        newPos = transform.position;

        if (captured)
        {
            newPos.x = player.transform.position.x;
            newPos.y = player.transform.position.y;
            newPos.z = player.transform.position.z;
        }
        else
        {
            float dz = player.transform.position.z - newPos.z;
            float dx = player.transform.position.x - newPos.x;

            //angle = Mathf.Atan2(dz, dx);

            //newPos.x += Mathf.Cos(angle) * speed * -1;
            //newPos.z += Mathf.Sin(angle) * speed * -1;

            if (Mathf.Sqrt(Mathf.Pow(dx, 2) + Mathf.Pow(dz, 2)) < 10) captured = true;
        }

        transform.position = newPos;
	}

    public void changeTeam(string playerTeam)
    {
        team = "Red";
    }
}