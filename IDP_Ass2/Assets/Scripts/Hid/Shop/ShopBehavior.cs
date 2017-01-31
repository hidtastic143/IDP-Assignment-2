using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ShopBehavior : MonoBehaviour {

    public GameObject WeaponList, ArmourList, ConsumablesList;
    public GameObject WeaponPreview, ArmourPreview, ConsumablesPreview;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
    
    public void ShowWeapons()
    {
        // Right Panel Activation
        WeaponList.SetActive(true);
        ArmourList.SetActive(false);
        ConsumablesList.SetActive(false);

        // Left Panel Activation
        WeaponPreview.SetActive(true);
        ArmourPreview.SetActive(false);
        ConsumablesPreview.SetActive(false);
    }

    public void ShowArmour()
    {
        // Right Panel Activation
        WeaponList.SetActive(false);
        ArmourList.SetActive(true);
        ConsumablesList.SetActive(false);

        // Left Panel Activation
        WeaponPreview.SetActive(false);
        ArmourPreview.SetActive(true);
        ConsumablesPreview.SetActive(false);
    }

    public void ShowConsumables()
    {
        // Right Panel Activation
        WeaponList.SetActive(false);
        ArmourList.SetActive(false);
        ConsumablesList.SetActive(true);

        // Left Panel Activation
        WeaponPreview.SetActive(false);
        ArmourPreview.SetActive(false);
        ConsumablesPreview.SetActive(true);
    }
}
