
using UnityEngine;
using UnityEngine.UI;

public class PaddleControlling : MonoBehaviour
{
    public GameObject paddleLeft;
    private float currentSpeed;
    public int speed = 10;
    private bool turn = false;
    private bool switcing =false;
    public GameObject paddleRight;

    
    void Start()
    {
        
    }


    void Update()
    {
        if (turn)
        {
           paddleLeft.transform.Translate(Vector2.up * currentSpeed* Time.deltaTime);
        }
        else if(switcing)
        {
            paddleRight.transform.Translate(Vector2.up*currentSpeed* Time.deltaTime);
        }
        
        
    }
    public void LeftUp()
    {
        turn = false;

    }
    public void LeftDown(int value)
    {
        currentSpeed =speed*value;
        turn = true;

    }
    public void RightDown(int number)
    {
        currentSpeed = number * speed;
        switcing = true;

    }
    public void RightUp()
    {
        
       switcing=false; 

    }

}
