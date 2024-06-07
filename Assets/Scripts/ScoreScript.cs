using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;
    AudioManager audioManager;
    // Start is called before the first frame update
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
{
    ScoreNum = 0;
    MyscoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    MyscoreText.text = "Score : " + ScoreNum;
}

    private void OnTriggerEnter2D(Collider2D collider)
{
    if (collider.CompareTag("MyBot"))
    {
        audioManager.PlaySFX(audioManager.collectbronze);
        ScoreNum += 1;
        Destroy(collider.gameObject);
        MyscoreText.text = "Score : " + ScoreNum;
    }
    else if (collider.CompareTag("silver"))
    {
        audioManager.PlaySFX(audioManager.collectsilver);
        ScoreNum += 5;
        Destroy(collider.gameObject);
        MyscoreText.text = "Score : " + ScoreNum;

    }
    else if (collider.CompareTag("gold"))
    {
        audioManager.PlaySFX(audioManager.collectgold);
        ScoreNum += 10;
        Destroy(collider.gameObject);
        MyscoreText.text = "Score : " + ScoreNum;
    }


}


}
