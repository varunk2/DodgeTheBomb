using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 6f;
    public GameManagerController gameManagerController;
    public ExitController exitController;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);

        if (Input.GetKeyDown("escape"))
        {
            //Debug.Log("COMMAND TO QUIT APPLICATION!!!!");
            //exitController.QuitApplication();
            Application.Quit();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameManagerController.EndGame();
    }
}
