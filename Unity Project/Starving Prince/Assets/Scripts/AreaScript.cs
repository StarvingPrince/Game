using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaScript : MonoBehaviour {
    GameObject princess;

	// Use this for initialization
	void Start () {
        princess = GameObject.Find("Princess");
	}
	
	// Update is called once per frame
	void Update () {
        OnTriggerEnter(princess.GetComponent<Collider>());
	}

    void OnTriggerEnter(Collider character)
    {
        if (character.gameObject.name == "Princess")
        {
            princess.GetComponent<PrincessScript>().changeTeam("FUCK");
            print("FUCK");
        }
    }
}
