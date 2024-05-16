using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Bot)
    {
        if (Bot.tag == "MyBot")
        {
            ScoreNum += 1;
            Destroy(Bot.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }
    }
}
