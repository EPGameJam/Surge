using UnityEngine;
using UnityEngine.Tilemaps;

public class WireController : MonoBehaviour
{
	public Grid Grid;

	public Tilemap WireTilemap;
	public Tilemap TerrainTilemap;

	public Tile WireTileGreen;
	public Tile WireTileYellow;
	public Tile WireTileRed;
	public Tile WireTileTransformer;
	public Tile WireTileSubstation;
	

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
				if (TerrainTilemap.HasTile(cellPos) && !WireTilemap.HasTile(cellPos))
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
					WireTilemap.SetTile(cellPos, WireTileGreen);
					return;
				case 2:
					WireTilemap.SetTile(cellPos, WireTileYellow);
					return;
				case 3:
					WireTilemap.SetTile(cellPos, WireTileRed);
					return;
				case 4:
					WireTilemap.SetTile(cellPos, WireTileTransformer);
					return;
				case 5:
					WireTilemap.SetTile(cellPos, WireTileSubstation);
					return;
				default:
					return;
		}
	}

	
}
