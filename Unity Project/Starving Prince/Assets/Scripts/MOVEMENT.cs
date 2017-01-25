using UnityEngine;
using System.Collections;

public class MOVEMENT : MonoBehaviour {
    Vector3 newPos;
    Rigidbody playerPhysics;

    bool kJump = false;
    bool kRight = false;
    bool kLeft = false;
    bool kUp = false;
    bool kDown = false;

    public float speed = 1;
    public int jumpHeight = 70;

    // Use this for initialization
    void Start () {
        playerPhysics = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        newPos = transform.position;

        if (Input.GetKeyDown("space")) kJump = true;
        if (Input.GetKeyDown("d")) kRight = true;
        if (Input.GetKeyDown("a")) kLeft = true;
        if (Input.GetKeyDown("w")) kUp = true;
        if (Input.GetKeyDown("s")) kDown = true;

        if (Input.GetKeyUp("space")) kJump = false;
        if (Input.GetKeyUp("d")) kRight = false;
        if (Input.GetKeyUp("a")) kLeft = false;
        if (Input.GetKeyUp("w")) kUp = false;
        if (Input.GetKeyUp("s")) kDown = false;

        if (kJump) playerPhysics.velocity = new Vector3(0, jumpHeight, 0);
        if (kLeft) newPos.x -= speed;
        if (kRight) newPos.x += speed;
        if (kUp) newPos.z += speed;
        if (kDown) newPos.z -= speed;

        transform.position = newPos;
    }
}
