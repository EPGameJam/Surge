using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ToolSelectionHover : MonoBehaviour
{
    public Grid Grid;

    public Tilemap ToolTilemap;

    public int ToolSelected;

    public Sprite[] ToolSprites;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        var cellPos = Grid.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));

        ToolTilemap.ClearAllTiles();

        var tile = ScriptableObject.CreateInstance<Tile>();
        tile.color = new Color(64, 64, 64, 0.75f);
        tile.sprite = ToolSprites[ToolSelected];
        ToolTilemap.SetTile(cellPos, tile);
    }
}