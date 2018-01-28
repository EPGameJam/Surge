using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

public class ItemCountController : MonoBehaviour
{
	public Text Wire1Text;
	public static int Wire1TotalNum = 15;
	public static int Cost1 = 1;

	public Text Wire2Text;
	public static int Wire2TotalNum = 20;
	public static int Cost2 = 2;

	public Text Wire3Text;
	public static int Wire3TotalNum = 20;
	public static int Cost3 = 4;

	public Text TransformerText;
	public static int TransformerNum = 20;
	public static int Cost4 = 10;
	
	public Text SubstationText;
	public static int SubstationNum = 20;
	public static int Cost5 = 20;

	public Text TextCash;
	public static int CashTotal = 100;

	// Use this for initialization
	void Start ()
	{
		UpdateItemNumOnCash();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateItemNumOnCash();
	}

	void UpdateItemNumOnCash()
	{
		Wire1TotalNum = CashTotal / Cost1;
		Wire2TotalNum = CashTotal / Cost2;
		Wire3TotalNum = CashTotal / Cost3;
		TransformerNum = CashTotal / Cost4;
		SubstationNum = CashTotal / Cost5;
		Wire1Text.text = Wire1TotalNum.ToString();
		Wire2Text.text = Wire2TotalNum.ToString();
		Wire3Text.text = Wire3TotalNum.ToString();
		TransformerText.text = TransformerNum.ToString();
		SubstationText.text = SubstationNum.ToString();
		TextCash.text = CashTotal.ToString();
	}

	public static bool SelectUpdate(int num)
	{
		switch (num)
		{
				case 1:
					if (Wire1TotalNum > 0)
					{
						CashTotal -= Cost1;
						return true;
					}
					return false;
				case 2:
					if (Wire2TotalNum > 0)
					{
						CashTotal -= Cost2;
						return true;
					}
					return false;
				case 3:
					if (Wire3TotalNum > 0)
					{
						CashTotal -= Cost3;
						return true;
					}
					return false;
				case 4:
					if (TransformerNum > 0)
					{
						CashTotal -= Cost4;
						return true;
					}
					return false;
				case 5:
					if (SubstationNum > 0)
					{
						CashTotal -= Cost5;
						return true;
					}
					return false;
				default:
					return false;
		}
	}
}
