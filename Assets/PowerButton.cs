using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class PowerButton : MonoBehaviour {

	public GameObject PowerOn;
	public GameObject PowerOff;
	public Boolean Toggled;
	
	// Use this for initialization
	void Start ()
	{
		Toggled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			var MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			var MouseWorldPos = Camera.main.ScreenToWorldPoint(MousePos);
			Vector2 MouseVec = new Vector2(MouseWorldPos.x, MouseWorldPos.y);
			Collider2D toggleButton = PowerOn.GetComponent<Collider2D>();
			if (toggleButton.bounds.Contains(MouseVec))
			{
				Toggled = !Toggled;
			}
		}
		SpriteRenderer PowOn = PowerOn.GetComponent <SpriteRenderer>();
		SpriteRenderer PowOff = PowerOff.GetComponent<SpriteRenderer>();
		if (Toggled)
		{
			PowOn.enabled = true;
			PowOff.enabled = false;
		}
		else
		{
			PowOn.enabled = false;
			PowOff.enabled = true;
		}
	}
}
