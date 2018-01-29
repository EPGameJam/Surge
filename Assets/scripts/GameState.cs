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

	public string toolboxItem;
	
	// Use this for initialization
	void Start ()
	{
		time = 0;
		toolboxItem = "create";
	}
	
	// Update is called once per frame
	void Update ()
	{
		updateTime();
		toolboxItem = getToolboxUpdate(toolboxItem);
	}

	void updateTime()
	{
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
	}

	string getToolboxUpdate(string item)
	{
		//should be boolean
		string toggleToolbox = "this is where it checks a boolean value if the tool selection has been changed";
		if (toggleToolbox == "create")
		{
			//this should be a string value obtained from a stored value
			//(either create, move, or destroy)

			//this will be deleted
			toggleToolbox = "create";
			
			item = toggleToolbox;
		}
		return item;
	}
}
