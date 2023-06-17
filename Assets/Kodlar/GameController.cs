using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
   

    [SerializeField] public GameObject endOfRoundPanel;

    EnemyMonster myEnemyMonster;
    
    public int score=0;
    public int level = 1;
    public int missilesLeft = 30;

    //scores
    private int missileDestroyedPoints = 25;

    [SerializeField] private TextMeshProUGUI myScoreText;
    [SerializeField] private TextMeshProUGUI myLevelText;
    [SerializeField] private TextMeshProUGUI myMissilesLeftText;
    // Start is called before the first frame update
    void Start()
    {
       myEnemyMonster = GameObject.FindObjectOfType<EnemyMonster>();
        
        UpdateScoreText();
        UpdateLevelText();
        UpdateMissilesLeftText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMissilesLeftText()
    {
        myMissilesLeftText.text = "Missiles Left: " + missilesLeft;
    }

    public void UpdateScoreText()
    {
        myScoreText.text = "Score: " + score;
    }

    public void UpdateLevelText()
    {
        myLevelText.text = "Level: " + level;
    }

    public void AddMissileDestroyedPoints()
    {
        score += missileDestroyedPoints;
        UpdateScoreText();
    }

    public void ActivateEndOfRoundPanel()
    {

        int totalScore = missilesLeft * missileDestroyedPoints;
        Debug.Log("Activating end of round panel. Total Score: " + totalScore);

        // Set the score text on the end-of-round panel
        TextMeshProUGUI scoreText = endOfRoundPanel.GetComponentInChildren<TextMeshProUGUI>();
        if (scoreText != null)
        {
            scoreText.text = "Score: " + totalScore;
        }

        // Activate the end-of-round panel
        endOfRoundPanel.SetActive(true);

    }
}
