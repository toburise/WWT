using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public float timeout = 5f;
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timeout());
    }
    void FixedUpdate()
    {
        transform.Translate(0, -moveSpeed, 0);
    }

    IEnumerator Timeout()
    {
        yield return new WaitForSeconds(timeout);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
