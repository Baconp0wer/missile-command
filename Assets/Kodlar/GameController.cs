using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int score=0;
    public int level = 1;
    public int missilesLeft = 30;

    [SerializeField] private TextMeshProUGUI myScoreText;
    [SerializeField] private TextMeshProUGUI myLevelText;
    [SerializeField] private TextMeshProUGUI myMissilesLeftText;
    // Start is called before the first frame update
    void Start()
    {
        myScoreText.text = "Score: " + score;
        myLevelText.text = "Level: " + level;
        
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
}
