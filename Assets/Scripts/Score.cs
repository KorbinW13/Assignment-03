using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int PinCount;
	public static int pinHighScore;

	public Text text;
	public Text HighScore;

	void Start ()
	{
		PinCount = 0;
		HighScore.text = "High Score: " + pinHighScore;
	}

	void Update ()
	{
		text.text = PinCount.ToString();
		if (pinHighScore < PinCount) 
		{
			pinHighScore = PinCount;
		}
		HighScore.text = "High Score: " + pinHighScore;
    }
}
