using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    private PipePassedEventChannel pipePassedEventChannel;

    public int Score { get; private set; }

    private void Awake()
    {
        pipePassedEventChannel= GetComponent<PipePassedEventChannel>();
    }
    private void OnEnable()
    {
        pipePassedEventChannel.OnEventPublished += IncrementScore;
    }

    private void IncrementScore()
    {
        Score++;
    }
}
