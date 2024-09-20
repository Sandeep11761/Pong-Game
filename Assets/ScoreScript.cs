using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public Text leftScore;
    private int leftScoring;
    public GameObject ball;
    public Text rightScoring;
    private int rightScore; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeftScoring()
    {
        leftScoring++;
        leftScore.text = leftScoring.ToString("0");
    }


    public void RightScoring()
    {
        rightScore++;
        rightScoring.text=rightScore.ToString("0");
    }
    public void PlayeButton()
    {

        SceneManager.LoadScene(0);
    }
   public  void GameQuit()
    {
        Application.Quit();
    }
}
