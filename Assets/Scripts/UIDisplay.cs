using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    
    [Header("Health")]
    [SerializeField] Slider healthSlider;
    [SerializeField] Health playerHealth;

    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }

    void Start()
    {
        healthSlider.maxValue = playerHealth.GetHealth();        
    }


    void Update()
    {
        healthSlider.value = playerHealth.GetHealth();  
        scoreText.text = score.GetScore().ToString("000000000");
    }
}
