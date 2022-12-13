using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject cubePrefab;
    void Update()
    {
        Instantiate(cubePrefab, transform.position, Quaternion.identity);

    }

}
