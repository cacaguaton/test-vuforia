using System;
using UnityEngine;

public class InstatiateObject : MonoBehaviour
{

        [SerializeField]
    private GameObject objectTiInstantiate;

    public void Instantiate(Transform target)
    {
        Instantiate(objectTiInstantiate, target.position,Quaternion.identity);
    }

}
