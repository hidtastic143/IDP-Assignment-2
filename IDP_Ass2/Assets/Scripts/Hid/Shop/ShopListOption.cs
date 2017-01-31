using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShopListOption : MonoBehaviour {

    public List<WeaponObject> WeaponOptions;
    public List<ArmourObject> ArmourOptions;
    public List<ConsumableObject> ConsumablesOptions;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetOnPreview(string name)
    {
        foreach (WeaponObject options in WeaponOptions)
        {
            if (options == null)
                continue;

            if (options.Name.Equals(name))
                options.active = true;
            else
                options.active = false;
        }

        foreach (ArmourObject options in ArmourOptions)
        {
            if (options == null)
                continue;

            if (options.Name.Equals(name))
                options.active = true;
            else
                options.active = false;
        }

        foreach (ConsumableObject options in ConsumablesOptions)
        {
            if (options == null)
                continue;

            if (options.Name.Equals(name))
                options.active = true;
            else
                options.active = false;
        }
    }

    public int FindCost()
    {
        foreach (WeaponObject options in WeaponOptions)
        {
            if (options == null)
                continue;

            if (options.active)
            {
                return options.cost;
            }
        }

        foreach (ArmourObject options in ArmourOptions)
        {
            if (options == null)
                continue;

            if (options.active)
            {
                return options.cost;
            }
        }

        foreach (ConsumableObject options in ConsumablesOptions)
        {
            if (options == null)
                continue;

            if (options.active)
            {
                return options.cost;
            }
        }

        return -1;
    }
}
