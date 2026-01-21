using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject pipa;
    public float timer = 1f;
    float waktu;

    void Start()
    {
        waktu = timer;
    }

    void Update()
    {
        if (waktu <= 0)
        {
            Instantiate(pipa, transform.position, Quaternion.identity);
            waktu = timer;
        }
        else
        {
            waktu -= Time.deltaTime;
        }
    }
}

