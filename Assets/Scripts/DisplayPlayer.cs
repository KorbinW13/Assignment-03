using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayer : MonoBehaviour
{
    public Text PlayerName;
    public Text HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerName.text = KeepData.PlayerName;
        HighScoreText.text = "High Score: " + Score.pinHighScore;
    }
}
