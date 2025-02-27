using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float spawnRate = 5.0f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-9.5f,9.5f),7.5f,0);
            Instantiate(enemy, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
    
    }
}
