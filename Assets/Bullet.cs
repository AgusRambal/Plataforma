using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    private Scene scene;
    float moveSpeed = 3;

    Rigidbody2D rb;

    CharacterController2D target;
    Vector2 moveDirection;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<CharacterController2D>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Hit");
            Application.LoadLevel(scene.name);
        }
    }
}
