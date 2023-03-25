using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateCars : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 4; i++)
            {
                Instantiate(prefab, new Vector3(3, 2*j+3, i * 10), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("now");

    }
}
        
    