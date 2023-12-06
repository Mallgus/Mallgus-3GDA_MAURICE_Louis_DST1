using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToInstantiate;
    public Vector3 localSpawnOffset;

    public void Spawn()
    {
        Instantiate(ObjectToInstantiate, transform.TransformPoint(localSpawnOffset), transform.rotation);
    }
}
