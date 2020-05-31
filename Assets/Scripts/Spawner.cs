using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public float SpawnInterval = 5f;
    public float CurrentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        if(CurrentTime > SpawnInterval)
        {
            CurrentTime = 0;
            
        }
    }
}
