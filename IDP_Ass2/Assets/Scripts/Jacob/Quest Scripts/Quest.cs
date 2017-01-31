using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Quest : MonoBehaviour
{

    public Text QuestName;
    public Text QuestDescription;
    public Text QuestObjective;
    public Text QuestDestination;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuestTexts()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "Main Quest")
        {
            QuestName.text = "The Chosen One";
            QuestDescription.text = "Description: This is the main quest.";
            QuestObjective.text = "Objective: find the legendary sword (0/1)";
            QuestDestination.text = "Find: The Cave of Legends";
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Quest01")
        {
            QuestName.text = "Help the farmer";
            QuestDescription.text = "Description: This is the first side quest.";
            QuestObjective.text = "Objective: Kill Wolves (3/10)";
            QuestDestination.text = "Find: The Farmer";
        }
        if (EventSystem.current.currentSelectedGameObject.name == "Quest02")
        {
            QuestName.text = "A Nightmare";
            QuestDescription.text = "Description: This is the second side quest.";
            QuestObjective.text = "Objective: finish assignments (1/4)";
            QuestDestination.text = "Find: Lecturer";
        }
    }
}