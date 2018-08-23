using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class Tags
{
    public const string MainController = "MainController";
    public const string GameController = "GameController";
    public const string Player = "Player";
}
public delegate void BirdSensorEventHandler();
public class BirdSensor : MonoBehaviour
{
   
    public event BirdSensorEventHandler OnBirdSensed;
    private void Awake()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Tags.Player)) NotifyBirdSensed();
    }

    private void NotifyBirdSensed()
    {
        OnBirdSensed?.Invoke();
    }

}
