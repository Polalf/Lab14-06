using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pool
{ 
    [SerializeField] private GameObject prefab;

    [SerializeField] private Transform parent;

    [SerializeField] private int limit;

    [SerializeField] private List<GameObject> pool;
    public void Inizialize()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < limit; i++)
        {
            GameObject instance = GameObject.Instantiate(prefab,parent);
            instance.SetActive(false);
            pool.Add(instance);
        }
    }

    public GameObject Get()
    {
        foreach (GameObject instance in pool)
        {
            if(instance.activeSelf == false)
            {
                instance.SetActive(true);
                return instance;
            }

        }

        GameObject newInstance = GameObject.Instantiate(prefab,parent);
        pool.Add(newInstance);
        return newInstance;
    }
 }
