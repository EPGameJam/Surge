using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Tilemaps;

public class WireController : MonoBehaviour
{
	public Grid Grid;

	public Tilemap Tilemap;

	public Tile WireTile;

	public GameObject InvisibleWall;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			if (Utils.CheckInBoundary(InvisibleWall.GetComponent<Collider>(), mousePos))
			{
				var cellPos = Grid.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));
				if (!Tilemap.HasTile(cellPos))
				{
					int currentlySelectedObj = InventorySelection.CurrentlySelectedObj;
					bool exec = ItemCountController.SelectUpdate(currentlySelectedObj);
					if (exec)
					{
						Tilemap.SetTile(cellPos, WireTile);
					}
				}
			}
		}
	}

	
}
