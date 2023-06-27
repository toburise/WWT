using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject rockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
    }
    IEnumerator SpawnRocks()
    {
        while (true)
        {
            float randomTime = Random.Range(2f, 5f);

            yield return new WaitForSeconds(randomTime);
            Instantiate(rockPrefab, new Vector3(Random.Range(-22.3f,5.4f),8.5f,-41), Quaternion.identity);
        }
    }

}

