using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donus : MonoBehaviour
{
    public Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(vec);
        
        
    }
}
