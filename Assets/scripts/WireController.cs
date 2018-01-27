using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WireController : MonoBehaviour
{
	public Grid Grid;

	public Tilemap Tilemap;

	public Tile WireTile;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			var cellPos = Grid.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));
			Tilemap.SetTile(cellPos, WireTile);
		}
	}
}
