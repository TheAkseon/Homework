using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public GameObject _temlpate;
    [SerializeField] public Transform _spawnPoint;
    
    void Start()
    {
        Instantiate(_temlpate, _spawnPoint.position, Quaternion.identity);  
    }
}
