using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool LevelCompplete = false;
    // Start is called before the first frame update
     private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "sword"&&!LevelCompplete)
        {
            LevelCompplete = true;
            Invoke("Complete1", 2f);

        }
    }
    private void Complete1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
