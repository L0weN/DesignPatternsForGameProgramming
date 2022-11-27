using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject medPrefab;
    public Terrain terrain;
    TerrainData terrainData;

    void Start()
    {
        terrainData = terrain.terrainData;
        InvokeRepeating("CreateEgg", 1f, 0.3f);
        InvokeRepeating("CreateMedkit", 1f, 0.3f);
    }

    void CreateEgg()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject egg = Instantiate(eggPrefab, pos, Quaternion.identity);
        egg.name = "Egg";
    }

    void CreateMedkit()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 10;
        GameObject medkit = Instantiate(medPrefab, pos, Quaternion.identity);
        medkit.name = "Medkit";

    }
}
