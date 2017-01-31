using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (Text))]
[RequireComponent (typeof (RectTransform))]

public class DialogueText : MonoBehaviour 
{
	public float typeSpeed;
	public float startDelay;
	public float volumeVariation;
	public bool startOnAwake;

	private int counter;
	private string textToType;
	private bool typing;
	private Text textComp;
    //string[] DialogueText1 = new string[] { "1. Laik's super awesome custom typewriter script", "2. You can click to skip to the next text", "3.All text is stored in a single string array", "4. Ok, now we can continue", "5. End Kappa" };
    //string[] DialogueText2 = new string[] { "asdasdasd click to skip to the next text", "3.All text is stored in a single string array", "4. Ok, now we can continue", "5. End Kappa" };
    void Awake()
	{ 
		textComp = GetComponent<Text>();
	

		counter = 0;
		textToType = textComp.text;
		textComp.text = "";

		if(startOnAwake)
		{
			InvokeRepeating("Type", startDelay, typeSpeed);
		}
	}

	public void StartTyping()
	{	
		if(!typing)
		{
			InvokeRepeating("Type", startDelay, typeSpeed);
		}
		else
		{
			print(gameObject.name + " : Is already typing!");
		}
	}

	public void StopTyping()
	{
		typing = false;
		CancelInvoke("Type");
	}

	private void Type()
	{	
		typing = true;
		textComp.text = textComp.text + textToType[counter];
		counter++;


		if(counter == textToType.Length)
		{	
			typing = false;
			CancelInvoke("Type");

        }
	}
}
