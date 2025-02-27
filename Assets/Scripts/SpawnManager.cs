using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float spawnRate = 5.0f;
    [SerializeField] private GameObject enemyContainer;

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
            GameObject newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity);
            newEnemy.transform.parent = enemyContainer.transform;
            yield return new WaitForSeconds(spawnRate);
        }
    
    }
}
