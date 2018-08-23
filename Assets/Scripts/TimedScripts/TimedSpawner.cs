using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float spawnDelayInSeconds= 3f;
    private void OnEnable()
    {
        StartCoroutine(SpawnPrefabsRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
    private IEnumerator SpawnPrefabsRoutine()
    {
        while(true)
        {
            //rapport d'erreur
            yield return new WaitForSeconds(spawnDelayInSeconds);
            SpawnPrefab();
        }
    }

    private void SpawnPrefab()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
