using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float nilaiRandom;
    void Star()
    {
        nilaiRandom = Random.Range(-2.91f, 2.31f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);
    }
}