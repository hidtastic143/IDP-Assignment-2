using UnityEngine;
using System.Collections;

public class WeaponObject : ShopObject {

    public int damage;
	
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
        image.enabled = true;
        nameOfWeapon.enabled = true;
        description.enabled = true;
        costOnScreen.enabled = true;
        costOnScreen.text = "Cost : " + cost;
        nameOfWeapon.text = Name;
        description.text = "Damage : " + damage;
    }
}
