using UnityEngine;
using System;

public class SelectTool : MonoBehaviour
{
	public GameObject Background;
	public GameObject DestroyButton;
	public Boolean Toggled;
	
	// Use this for initialization
	void Start ()
	{
		Toggled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			var MouseWorldPos = Camera.main.ScreenToWorldPoint(MousePos);
			Vector2 MouseVec = new Vector2(MouseWorldPos.x, MouseWorldPos.y);
			Collider2D toggleButton = DestroyButton.GetComponent<Collider2D>();
			if (toggleButton.bounds.Contains(MouseVec))
			{
				Toggled = !Toggled;
			}
		}
		SpriteRenderer BackgroundRenderer = Background.GetComponent <SpriteRenderer>();
		if (Toggled)
		{
			BackgroundRenderer.enabled = true;
		}
		else
		{
			BackgroundRenderer.enabled = false;
		}
	
	}
}
