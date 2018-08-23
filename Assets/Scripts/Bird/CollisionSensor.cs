using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void CollisionSensorEventHandler();

public class CollisionSensor : MonoBehaviour
{
    public event CollisionSensorEventHandler OnCollision;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision détecté!");
        NotifyCollisionSensed();
    }

    private void NotifyCollisionSensed()
    {
        OnCollision?.Invoke();
    }

}
