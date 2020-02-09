using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class a : MonoBehaviour
{
	public int score;
	public Text scoreText;
	
	void Update()
    {
		scoreText.text = "현재점수 : " + score.ToString();
    }
	
	public void scoreUp(){
		score++;
	}
}
