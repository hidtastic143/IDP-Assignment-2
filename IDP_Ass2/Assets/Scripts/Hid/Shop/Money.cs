using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Money : MonoBehaviour {
    public Text moneyUI;
    public ShopListOption Shopitems;
    public int money;
    public GameObject Buy;

	// Use this for initialization
	void Start () {
        moneyUI.text = money.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (money < Shopitems.FindCost())
        {
            Buy.SetActive(false);
            return;
        }
        else
        {
            Buy.SetActive(true);
        }
	}

    public void MoneyDeduction()
    {
        money -= Shopitems.FindCost();
        moneyUI.text = money.ToString();
    }
}
