using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{

    [Header("Parts")] [SerializeField] private GameObject pipeUp;
    [SerializeField] private GameObject pipeDown;
    [Header("Position")][SerializeField] private float minDistance = 1;
    [SerializeField] private float maxDistance = 3;
    [SerializeField] private float minHeight = -1;
    [SerializeField] private float maxHeight = 1;

    private BirdSensor birdSensor;
    private PipePassedEventChannel pipePassedEventChannel;
    private void Awake()
    {

        birdSensor = transform.root.GetComponentInChildren<BirdSensor>();
        RandomizePipeHeights();
        pipePassedEventChannel = GameObject.FindWithTag(Tags.GameController)
           .GetComponent<PipePassedEventChannel>();
    }
    private void OnEnable()
    {
        birdSensor.OnBirdSensed += NotifyPipePassed;
    }

    private void OnDisable()
    {
        birdSensor.OnBirdSensed -= NotifyPipePassed;
    }
    private void NotifyPipePassed()
    {
        pipePassedEventChannel.Publish();
    }

    private void RandomizePipeHeights()
    {
        var height = Random.Range(minHeight, maxHeight);
        transform.root.Translate(Vector3.up * height);
    }

    private void RandomizePipePositions()
    {
        var halfPipeHeight = pipeUp.GetComponent<SpriteRenderer>().size.y / 2f;

        var halfDistance = Random.Range(minDistance, maxDistance) / 2;

        var pipePosition = Vector3.up * halfPipeHeight + Vector3.up * halfDistance;

        pipeUp.transform.localPosition = pipePosition;
        pipeDown.transform.localPosition = -pipePosition;


    }
}
