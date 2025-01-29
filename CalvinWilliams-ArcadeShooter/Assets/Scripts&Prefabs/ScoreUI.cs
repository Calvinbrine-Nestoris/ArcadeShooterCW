using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GunshipMovement.score.ToString();
        if (highScore < GunshipMovement.score)
        {
            highScore = GunshipMovement.score;
        }
    }
}