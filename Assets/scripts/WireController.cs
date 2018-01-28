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
			if (CheckInBoundary(mousePos))
			{
				var cellPos = Grid.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));
				Tilemap.SetTile(cellPos, WireTile);
			}
		}
	}

	private Boolean CheckInBoundary (Vector3 mousePosition)
	{
		var mousePosInWorld = Camera.main.ScreenToWorldPoint(mousePosition);
		Collider boxCollider = InvisibleWall.GetComponent<Collider>();
		var boxColliderMaxX = boxCollider.bounds.max.x;
		var boxColliderMaxY = boxCollider.bounds.max.y;
		var boxColliderMinX = boxCollider.bounds.min.x;
		var boxColliderMinY = boxCollider.bounds.min.y;
		var normalMousePositionX = mousePosInWorld.x;
		var normalMousePositionY = mousePosInWorld.y;
		return (normalMousePositionX < boxColliderMaxX 
		        && normalMousePositionY < boxColliderMaxY
		        && normalMousePositionX > boxColliderMinX 
		        && normalMousePositionY > boxColliderMinY);
	}
}
