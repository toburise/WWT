using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{

    public float x;
    public float y;
    public float z;
    Vector3 vector3;

    // Start is called before the first frame update
    void Start() 
    {

        x = 18;
        y = Random.Range(-32, 14);
        z = -41;
        vector3 = new Vector3(x, y, z);
        transform.position = vector3;
    }
    

    // Update is called once per frame
    void Update()
    {
       
    }
}
