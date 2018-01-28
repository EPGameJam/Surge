using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlacementHover : MonoBehaviour
{
    public Grid Grid;

    public GameObject Collider;

    public Tilemap ToolTilemap;

    public int ToolSelected;

    public Sprite[] ToolSprites;

    public Shader Shader;

    private Shader _initialShader;

    // Use this for initialization
    void Start()
    {
        _initialShader = ToolTilemap.GetComponent<TilemapRenderer>().material.shader;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        var cellPos = Grid.WorldToCell(Camera.main.ScreenToWorldPoint(mousePos));

        ToolTilemap.ClearAllTiles();

        var tile = ScriptableObject.CreateInstance<Tile>();

        if (Utils.CheckInBoundary(Collider.GetComponent<Collider>(), mousePos))
        {
            tile.color = new Color(0.66f, 0.75f, 1f, 0.75f);
            //ToolTilemap.GetComponent<TilemapRenderer>().material.shader = Shader;
        }
        else
        {
            tile.color = new Color(1f, 0.75f, 0.66f, 0.5f);
            //ToolTilemap.GetComponent<TilemapRenderer>().material.shader = _initialShader;
        }
        
        tile.sprite = ToolSprites[ToolSelected];
        
        ToolTilemap.SetTile(cellPos, tile);
    }
}