using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Pool pool;
    [SerializeField] private List<Vector3> spawnerPoints;
    [SerializeField] private float cd = 2;
    [SerializeField] private float probability;

    private void Awake()
    {
        pool.Inizialize();
    }

    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    private void Spawn()
    {
        foreach (Vector3 point in spawnerPoints)
        {
            if(Random.value < probability)
            {
               GameObject cube =  pool.Get();

                cube.transform.position = point;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;

        foreach (Vector3 point in spawnerPoints)
        {
            Gizmos.DrawSphere(point, 0.5f);
        }
        
    }

    IEnumerator SpawnTimer()
    {
        while(true)
        {
            Spawn();
            yield return new WaitForSeconds(cd);
        }
        
    }
}
