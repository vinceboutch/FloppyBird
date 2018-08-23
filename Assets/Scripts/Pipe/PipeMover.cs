using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] private float speed=1;

	
	// Update is called once per frame
	void Update ()
    {
        transform.root.Translate(Vector3.left * speed * Time.deltaTime);
	}
}
