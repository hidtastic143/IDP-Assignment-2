using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonToggler : MonoBehaviour {

    public Toggle Weapon, Armour, Consumable, Sell;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetToggleWeapon()
    {
        Weapon.isOn = true;
        Armour.isOn = false;
        Consumable.isOn = false;
        Sell.isOn = false;
    }

    public void SetToggleArmour()
    {
        Weapon.isOn = false;
        Armour.isOn = true;
        Consumable.isOn = false;
        Sell.isOn = false;
    }

    public void SetToggleConsumable()
    {
        Weapon.isOn = false;
        Armour.isOn = false;
        Consumable.isOn = true;
        Sell.isOn = false;
    }
    
    public void SetToggleSell()
    {
        Weapon.isOn = false;
        Armour.isOn = false;
        Consumable.isOn = false;
        Sell.isOn = true;
    }
}
