using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WireController : MonoBehaviour
{
	public Grid grid;

	public Tilemap tilemap;

	public Tile wireTile;
	
	// Use this for initialization
	void Start () {
		tilemap.SetTile(new Vector3Int(0,0,0), wireTile);
		tilemap.SetTile(new Vector3Int(0,1,0), wireTile);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			var cellPos = grid.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));
			tilemap.SetTile(cellPos, wireTile);
		}
	}
}
