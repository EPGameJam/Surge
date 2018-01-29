using UnityEngine;

public class InventorySelection : MonoBehaviour
{
	public GameObject Wire1; //1
	public GameObject TextHighliter1;
	
	public GameObject Wire2; //2
	public GameObject TextHighliter2;
	
	public GameObject Wire3; //3
	public GameObject TextHighliter3;
	
	public GameObject Transformer; //4
	public GameObject TextHighliter4;

	public GameObject Substation; //5
	public GameObject TextHighliter5;

	public static int CurrentlySelectedObj;

	// Use this for initialization
	void Start ()
	{
		SpriteRenderer textHighliter1Renderer = TextHighliter1.GetComponent<SpriteRenderer>();
		textHighliter1Renderer.enabled = true;
		CurrentlySelectedObj = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
			var mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
			int itemNumber = IsItemSelected(mouseWorldPos);
			if (itemNumber == CurrentlySelectedObj)
			{
				return;
			}
			
			switch (IsItemSelected(mouseWorldPos))
			{
				case 1:
					SpriteRenderer textHighliter1Renderer = TextHighliter1.GetComponent<SpriteRenderer>();
					textHighliter1Renderer.enabled = true;
					DisableCurrentItem(CurrentlySelectedObj);
					CurrentlySelectedObj = 1;
					return;
				case 2:
					SpriteRenderer textHighliter2Renderer = TextHighliter2.GetComponent<SpriteRenderer>();
					textHighliter2Renderer.enabled = true;
					DisableCurrentItem(CurrentlySelectedObj);
					CurrentlySelectedObj = 2;
					return;
				case 3:
					SpriteRenderer textHighliter3Renderer = TextHighliter3.GetComponent<SpriteRenderer>();
					textHighliter3Renderer.enabled = true;
					DisableCurrentItem(CurrentlySelectedObj);
					CurrentlySelectedObj = 3;
					return;
				case 4:
					SpriteRenderer textHighliter4Renderer = TextHighliter4.GetComponent<SpriteRenderer>();
					textHighliter4Renderer.enabled = true;
					DisableCurrentItem(CurrentlySelectedObj);
					CurrentlySelectedObj = 4;
					return;
				case 5: 
					SpriteRenderer textHighliter5Renderer = TextHighliter5.GetComponent<SpriteRenderer>();
					textHighliter5Renderer.enabled = true;
					DisableCurrentItem(CurrentlySelectedObj);
					CurrentlySelectedObj = 5;
					return;
				default:
					return;
			}
		}
	}

	int IsItemSelected(Vector3 mousePos)
	{
		Collider2D wire1Collider = Wire1.GetComponent<Collider2D>();
		Collider2D wire2Collider = Wire2.GetComponent<Collider2D>();
		Collider2D wire3Collider = Wire3.GetComponent<Collider2D>();
		Collider2D transformerCollider = Transformer.GetComponent<Collider2D>();
		Collider2D substationCollider = Substation.GetComponent<Collider2D>();
		Vector2 mouseVec = new Vector2(mousePos.x, mousePos.y);

		if (wire1Collider.bounds.Contains(mouseVec))
		{
			return 1;
		} else if (wire2Collider.bounds.Contains(mouseVec))
		{
			return 2;
		} else if (wire3Collider.bounds.Contains(mouseVec))
		{
			return 3;
		} else if (transformerCollider.bounds.Contains(mouseVec))
		{
			return 4;
		} else if (substationCollider.bounds.Contains(mouseVec))
		{
			return 5;
		}
		else
		{
			return -1;
		}
	}

	void DisableCurrentItem(int currentNum)
	{
		switch (currentNum)
		{
			case 1:
				SpriteRenderer textHighliter1Renderer = TextHighliter1.GetComponent<SpriteRenderer>();
				textHighliter1Renderer.enabled = false;
				return;
			case 2:
				SpriteRenderer textHighliter2Renderer = TextHighliter2.GetComponent<SpriteRenderer>();
				textHighliter2Renderer.enabled = false;
				return;
			case 3:
				SpriteRenderer textHighliter3Renderer = TextHighliter3.GetComponent<SpriteRenderer>();
				textHighliter3Renderer.enabled = false;
				return;
			case 4:
				SpriteRenderer textHighliter4Renderer = TextHighliter4.GetComponent<SpriteRenderer>();
				textHighliter4Renderer.enabled = false;
				return;
			case 5:
				SpriteRenderer textHighliter5Renderer = TextHighliter5.GetComponent<SpriteRenderer>();
				textHighliter5Renderer.enabled = false;
				return;
			default:
				return;
		}
	}
}
