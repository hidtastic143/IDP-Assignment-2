using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Skill_Object : MonoBehaviour {

    string ObjectName;
    public Text Name;
    public Text Level;
    public Text Description;
    public Text Damage;
    public Text Cost;
    public Text SkillPoints;
    public Text SkillLevel;
    public short SP;
    short SkillLevel1;
    short SkillLevel2;
    short SkillLevel3;
    short SkillLevel4;
    short SkillLevel5;
    short SkillLevel6;
    short SkillLevel7;
    short SkillLevel8;
    short SkillLevel9;
    short SkillLevel10;
    public GameObject Level_button;

    // Use this for initialization
    void Start () {

        SP = 10;
        SkillPoints.text = SP.ToString();
        SkillLevel1 = 0;
        SkillLevel2 = 0;
        SkillLevel3 = 0;
        SkillLevel4 = 0;
        SkillLevel5 = 0;
        SkillLevel6 = 0;
        SkillLevel7 = 0;
        SkillLevel8 = 0;
        SkillLevel9 = 0;
        SkillLevel10 = 0;
        ObjectName = null;
        Level_button.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
	
	}

    public void LevelUP()
    {
        if (ObjectName != null)
        {
            if (ObjectName == "Regeneration Skill")
            {
                SkillLevel1++;
            }
            if (ObjectName == "Health up")
            {
                SkillLevel2++;
            }
            if (ObjectName == "Mastery up")
            {
                SkillLevel3++;
            }
            if (ObjectName == "Def up")
            {
                SkillLevel4++;
            }
            if (ObjectName == "Sp up")
            {
                SkillLevel5++;
            }
            if (ObjectName == "Knockback")
            {
                SkillLevel6++;
            }
            if (ObjectName == "Fury Swipe")
            {
                SkillLevel7++;
            }
            if (ObjectName == "Explosion")
            {
                SkillLevel8++;
            }
            if (ObjectName == "Armor Crash")
            {
                SkillLevel9++;
            }
            if (ObjectName == "Charge")
            {
                SkillLevel10++;
            }
            --SP;
            SkillPoints.text = SP.ToString();
            GetDesc(EventSystem.current.currentSelectedGameObject.name);
        }
    }

    public void setTexts()
    {
        GetDesc(EventSystem.current.currentSelectedGameObject.name);
    }

    void GetDesc(string objName)
    {
        Level_button.SetActive(true);
        if (objName != "Level Up" )
        {
            ObjectName = objName;
        }
        Debug.Log(ObjectName);
        Name.text = "Name: " + ObjectName;
        if (ObjectName == "Regeneration Skill")
        {
            Description.text = "Description: increases health regenaration.";
            Damage.text = "Regen: +5 health/second";
            Cost.text = "Sp Cost: Passive";
            SkillLevel.text = "Skill Level: " + SkillLevel1.ToString();
        }
        if (ObjectName == "Health up")
        {
            Description.text = "Description: Increases max health.";
            Damage.text = "Health: +20 health";
            Cost.text = "Sp Cost: Passive";
            SkillLevel.text = "Skill Level: " + SkillLevel2.ToString();
        }
        if (ObjectName == "Mastery up")
        {
            Description.text = "Description: Doubles active skill levels.";
            Damage.text = "Skill Levels 2x";
            Cost.text = "Sp Cost: Passive";
            SkillLevel.text = "Skill Level: " + SkillLevel3.ToString();
        }
        if (ObjectName == "Def up")
        {
            Description.text = "Description: increases defence.";
            Damage.text = "Defence: +5";
            Cost.text = "Sp Cost: Passive";
            SkillLevel.text = "Skill Level: " + SkillLevel4.ToString();
        }
        if (ObjectName == "Sp up")
        {
            Description.text = "Description: increases SP.";
            Damage.text = "SP: +20";
            Cost.text = "Sp Cost: Passive";
            SkillLevel.text = "Skill Level: " + SkillLevel5.ToString();
        }
        if (ObjectName == "Knockback")
        {
            Description.text = "Description: Knocks enemies back.";
            Damage.text = "Damage: 120% Atk";
            Cost.text = "Sp Cost: 20";
            SkillLevel.text = "Skill Level: " + SkillLevel6.ToString();
        }
        if (ObjectName == "Fury Swipe")
        {
            Description.text = "Description: Quick swipes which damage enemies.";
            Damage.text = "Damage: 50% atk X 4";
            Cost.text = "Sp Cost: 20";
            SkillLevel.text = "Skill Level: " + SkillLevel7.ToString();
        }
        if (ObjectName == "Explosion")
        {
            Description.text = "Description: Massive area of dffect damage around player.";
            Damage.text = "Damage: 500% atk";
            Cost.text = "Sp Cost: 50";
            SkillLevel.text = "Skill Level: " + SkillLevel8.ToString();
        }
        if (ObjectName == "Armor Crash")
        {
            Description.text = "Description: Reduces enemy's armor.";
            Damage.text = "Def Reduction: 10";
            Cost.text = "Sp Cost: 20";
            SkillLevel.text = "Skill Level: " + SkillLevel9.ToString();
        }
        if (ObjectName == "Charge")
        {
            Description.text = "Description: Lunge forward and deals damage.";
            Damage.text = "Damage: 140% ATK";
            Cost.text = "Sp Cost: 20";
            SkillLevel.text = "Skill Level: " + SkillLevel10.ToString();
        }

    }
}
