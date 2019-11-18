using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                obj.transform.position = new Vector3(i, j, 0);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
