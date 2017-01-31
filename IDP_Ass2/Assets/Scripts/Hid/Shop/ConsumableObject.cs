using UnityEngine;
using System.Collections;

public class ConsumableObject : ShopObject {

    public string DescriptionOfItem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (active)
            ShowOnScreen();
        else
            DontShowOnScreen();
	
	}

    public override void ShowOnScreen()
    {
        base.ShowOnScreen();
        description.text = "Description : " + DescriptionOfItem;
    }
}
