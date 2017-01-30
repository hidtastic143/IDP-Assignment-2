using UnityEngine;
using System.Collections;

public class ConsumableObject : ShopObject {

    string DescriptionOfItem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void ShowOnScreen()
    {
        base.ShowOnScreen();
        description.text = DescriptionOfItem;
    }
}
