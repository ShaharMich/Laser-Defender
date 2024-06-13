using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }

    void Start()
    {
        scoreText.text = "You Scored:\n" + score.GetScore();
    }

}
