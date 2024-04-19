using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Tankprefab;


    void Start()
    {
        Instantiate(Tankprefab, transform.position,Quaternion.identity);
    }

 
    
}
