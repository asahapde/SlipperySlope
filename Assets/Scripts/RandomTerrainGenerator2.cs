using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTerrainGenerator2 : MonoBehaviour
{
    public List<GameObject> ringPrefab = new List<GameObject>();
    public List<Material> materials = new List<Material>();
    public List<GameObject> rings;


    private float currTime = 1.0f;
    private float currY = -1.2f;
    private float currZ = -3;


    void Update()
    {
        currTime += Time.deltaTime;

        if(currTime > 2) 
        {
            for(int i = 0; i < 10; i++)
            {
                SpawnRing(0, currY, currZ, 999);
                currY = currY - 0.4f;
                currZ = currZ - 1f;
            }
            
            currTime = 0;
        }

    }

    void SpawnRing(float x, float y, float z, int ringNumber)
    {
        GameObject cloneRing;
        if (ringNumber == 999)
        {
            cloneRing = Instantiate(ringPrefab[Random.Range(0, ringPrefab.Count)]);
        } else
        {
            cloneRing = Instantiate(ringPrefab[ringNumber]);
        }
        
        GameObject currentRing = cloneRing;
        currentRing.GetComponent<MeshRenderer>().material = materials[Random.Range(0, materials.Count)];


        rings.Add(currentRing);
        Instantiate(currentRing, new Vector3(x, y, z), Quaternion.Euler(new Vector3(0, 0, Random.Range(-50,50))));
    }
}
