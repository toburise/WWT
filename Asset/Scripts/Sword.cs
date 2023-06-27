using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag(Const.SOS))
        {
            var c3D = col.GetComponent<Collider>();//
            if (c3D)                                //
                c3D.enabled = false;//
            col.transform.SetParent(transform);  //  setparent de apple is son for arrow (apple bay theo arrow)
        }
    }
}
