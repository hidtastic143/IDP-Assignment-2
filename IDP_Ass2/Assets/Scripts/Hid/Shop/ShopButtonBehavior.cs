using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShopButtonBehavior : MonoBehaviour {

    public Toggle toggler;

    Vector3 OriginalScale, ToggledScale;

	// Use this for initialization
	void Start () {
        OriginalScale = transform.localScale;
        ToggledScale = transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (toggler.isOn)
        {
            transform.localScale = ToggledScale;
        }
        else
        {
            transform.localScale = OriginalScale;
        }
	}
}
