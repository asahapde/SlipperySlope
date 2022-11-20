using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTerrainGenerator : MonoBehaviour
{
    public List<GameObject> rings;

    void Start()
    {

    }

    void Update()
    {
        
    }

    void SpawnRing(float x, float y, float z)
    {
        GameObject currentRing = rings[Random.Range(0, rings.Count)];
        Instantiate(currentRing, new Vector3(x, y, z), Quaternion.identity);
    }
}
