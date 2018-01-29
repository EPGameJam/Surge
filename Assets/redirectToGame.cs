using UnityEngine;
using UnityEngine.SceneManagement;

public class redirectToGame : MonoBehaviour
{

	public GameObject StartObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
		{
			var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			var mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
			var mousePos2D = new Vector2(mouseWorldPos.x, mouseWorldPos.y);
			Collider2D boxCollide = StartObject.GetComponent<Collider2D>();
			if (boxCollide.bounds.Contains(mousePos2D))
			{
				SceneManager.LoadScene("GameScene");
			}
		}
	}
}
