using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Tilemaps;

public class WireController : MonoBehaviour
{
	public Grid Grid;

	public Tilemap Tilemap;

	public Tile WireTileGreen;
	public Tile WireTileYellow;
	public Tile WireTileRed;
	public Tile WireTileTransformer;
	

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
						UpdateTileBasedOnCurrentSelect(currentlySelectedObj, cellPos);
					}
				}
			}
		}
	}

	void UpdateTileBasedOnCurrentSelect(int itemNum, Vector3Int cellPos) 
	{
		switch (itemNum)
		{
				case 1:
					Tilemap.SetTile(cellPos, WireTileGreen);
					return;
				case 2:
					Tilemap.SetTile(cellPos, WireTileYellow);
					return;
				case 3:
					Tilemap.SetTile(cellPos, WireTileRed);
					return;
				case 4:
					Tilemap.SetTile(cellPos, WireTileTransformer);
					return;
				default:
					return;
		}
	}

	
}
