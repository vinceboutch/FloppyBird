using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    private BirdPhysics birdPhysics;

    [SerializeField] private KeyCode flapKey = KeyCode.Space;

    private void Awake()
    {
        birdPhysics = transform.root.GetComponentInChildren<BirdPhysics>();
    }


    // Update is called once per frame
    private void Update ()
    {
		if( Input.GetKeyDown(flapKey))
        {
            birdPhysics.Flap();
        }
	}
}
