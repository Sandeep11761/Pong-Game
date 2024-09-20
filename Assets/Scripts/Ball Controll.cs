using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControll : MonoBehaviour
{
    public GameObject ball;
    private float speed = 8f;
    private Vector2[] direction = {Vector2.left,Vector2.right};
    private Rigidbody2D rb;
    public ScoreScript scoreManager;

    // Start is called before the first frame update

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        OnStart();
    }
    public void OnStart()
    {
        //ball direction after the game started
        GetComponent<Rigidbody2D>().velocity = direction[Random.Range(0, 2)]*speed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftScroe"))
        {
            scoreManager.LeftScoring();
            Invoke("Respawn", 1f);
        }
        else if (collision.gameObject.CompareTag("RightScore"))
        {
            scoreManager.RightScoring();
            Invoke("Respawn", 1f);
        }

    }

    public void Respawn()
    {
        rb.velocity = Vector2.zero;
        transform.position = new Vector2(0, 0);
       Invoke("OnStart",1);


    }
}
