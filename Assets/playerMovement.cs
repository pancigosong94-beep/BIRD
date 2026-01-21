using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpForce = 5f;
    int score = 0;

    public Text scoreTxt;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // tampilkan score
        scoreTxt.text = score.ToString();

        // loncat saat klik
        if (Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // tambah score
        if (collision.CompareTag("point"))
        {
            score++;
        }

        // mati saat kena pipa
        if (collision.CompareTag("pipa"))
        {
            Destroy(gameObject); // burung mati
            Time.timeScale = 0f; // game berhenti (opsional)
        }
    }
}
