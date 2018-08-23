using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour 
{

    private BirdPhysics birdPhysics;
    private CollisionSensor collisionSensor;
    [SerializeField] private KeyCode flapKey = KeyCode.Space;

    private void Awake()
    {
        var root = transform.root;
        birdPhysics = root.GetComponentInChildren<BirdPhysics>();
        collisionSensor = root.GetComponentInChildren<CollisionSensor>();
    }


    // Update is called once per frame
    private void Update ()
    {
		if( Input.GetKeyDown(flapKey))
        {
            birdPhysics.Flap();
        }
	}

    private void OnEnable()
    {
        collisionSensor.OnCollision += Die;
    }

    private void OnDisable()
    {
        collisionSensor.OnCollision -= Die;
    }

    private void Die()
    {
        Hide();
    }

    private void Hide()
    {
        transform.root.gameObject.SetActive(false);
    }
}
