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
            int a = 2;
            int z = Random.Range(3, 6);
                if(z < 4)
            {
                 a= -6;
            }
            else if (z < 5)
            {
                a = 0;
            }
            else if (z < 6)
            {
                a = 4;
            }
            Instantiate(prefab, new Vector3(3*i +10, 3, a), Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("now");

    }
}
        
    