using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Contador : MonoBehaviour
    
{
    public static int Score = 0;
    public string ScoreString = "Score";
    public Text TextScore;
    public static Contador GameController;
    void Awake()
    {
        GameController = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextScore != null)
        {
            TextScore.text = ScoreString = Score.ToString();
        }
    }
}
