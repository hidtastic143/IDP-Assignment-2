using UnityEngine;
using System.Collections;

public class SkillTab_Click : MonoBehaviour {

    public GameObject ActiveSkills;
    public GameObject PassiveSkills;

	// Use this for initialization
	void Start () {
        ActiveSkills.SetActive(false);
        PassiveSkills.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void onActive()
    {
        ActiveSkills.SetActive(false);
        PassiveSkills.SetActive(true);
    }
    public void onPassive()
    {
        ActiveSkills.SetActive(true);
        PassiveSkills.SetActive(false);
    }
}

