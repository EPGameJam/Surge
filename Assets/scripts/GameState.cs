using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{

	public int cashValue;
	public Text cashText;
	
	public int powerValue;
	public Text powerText;

	public Text timeText;
	public float time;
	
	// Use this for initialization
	void Start ()
	{
		time = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Start Time Update
		time += Time.deltaTime;
		int mins = Mathf.FloorToInt(time / 60);
		int secs = Mathf.FloorToInt(time % 60);
		string minutes;
		if (time < 600)
		{
			minutes = mins.ToString("0");
		}
		else
		{
			minutes = mins.ToString("00");
		}
		string seconds = secs.ToString("00");
		timeText.text = minutes + ":" + seconds;
		//End Time Update
	}
}
