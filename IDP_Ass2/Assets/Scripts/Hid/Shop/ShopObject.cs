﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShopObject : MonoBehaviour {

    public Text nameOfWeapon;
    public Image image;
    public Text description;
    public Text costOnScreen;

    public string Name;
    public int cost;
    public bool active;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    virtual public void ShowOnScreen()
    {
        image.enabled = true;
        nameOfWeapon.enabled = true;
        description.enabled = true;
        costOnScreen.enabled = true;
        costOnScreen.text = "Cost : " + cost;
        nameOfWeapon.text = Name;
    }

    protected void DontShowOnScreen()
    {
        image.enabled = false;
        nameOfWeapon.enabled = false;
        description.enabled = false;
        costOnScreen.enabled = false;
    }
}
