using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTerrainGenerator : MonoBehaviour
{
    public List<GameObject> ringPrefab;
    public List<Material> materials = new List<Material>();
    public List<GameObject> rings;


    private float currTime = 0.0f;
    private float currY = -1.2f;
    private float currZ = -3;

    void Start()
    {
        //SpawnRing(2,2,2);
    }

    void Update()
    {
        currTime += Time.deltaTime;

        //if(rings.Count < 10)
        //{
        //    SpawnRing(0, currY, currZ);
        //    currY = currY - 0.4f;
        //    currZ = currZ - 1f;
        //}

        if(currTime > 2) 
        {
            
            //Destroy(rings[0]);
            //rings.RemoveAt(0);

            for(int i = 0; i < 10; i++)
            {
                SpawnRing(0, currY, currZ);
                currY = currY - 0.4f;
                currZ = currZ - 1f;
            }
            
            currTime = 0;
        }

    }

    void SpawnRing(float x, float y, float z)
    {
        GameObject cloneRing = Instantiate(ringPrefab[Random.Range(0, ringPrefab.Count)]);
        GameObject currentRing = cloneRing;
        currentRing.GetComponent<MeshRenderer>().material = materials[Random.Range(0, materials.Count)];


        rings.Add(currentRing);
        Instantiate(currentRing, new Vector3(x, y, z), Quaternion.Euler(0, 0, Random.Range(-50, 50)));
    }
}
