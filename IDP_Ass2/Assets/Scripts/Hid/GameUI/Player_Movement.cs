using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

    private Animator animation;
    public Joy_Behavior moveJoystick;
    static Vector3 CurrentPosition;
    private Vector3 PrevVel, CurrentVel;

	// Use this for initialization
	void Start () {
        if (CurrentPosition != Vector3.zero)
            transform.localPosition = CurrentPosition;
        animation = GetComponent<Animator>();
        CurrentVel.Set(0, 0, 0);
        PrevVel = new Vector3(-0.5f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
       // EzioMovement();
        EzioJoyMovement();
        transform.localPosition += CurrentVel;
        CurrentPosition = transform.localPosition;
	}

    void EzioJoyMovement()
    {
        if (moveJoystick.InputDirection != Vector3.zero)
        {
            CurrentVel = 0.04f * moveJoystick.InputDirection;
            PrevVel = CurrentVel;
            if (moveJoystick.InputDirection.x > 0)
                animation.Play("Walk_Right");
            else if (moveJoystick.InputDirection.x < 0)
                animation.Play("Walk_Left");
        }
        else 
        {
            CurrentVel = Vector3.zero;
            if (PrevVel.x > 0)
                animation.Play("Idle_Right");
            else
                animation.Play("Idle_Left");
        }
    }

    void EzioMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            CurrentVel = new Vector3(0, 0.05f, 0);
            if (PrevVel.x < 0)
            {
                animation.Play("Walk_Left");
            }
            else
            {
                animation.Play("Walk_Right");
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            CurrentVel = new Vector3(0, -0.05f, 0);
            if (PrevVel.x < 0)
            {
                animation.Play("Walk_Left");
            }
            else
            {
                animation.Play("Walk_Right");
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            CurrentVel = new Vector3(0.05f, 0, 0);
            animation.Play("Walk_Right");
            PrevVel = CurrentVel;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            CurrentVel = new Vector3(-0.05f, 0, 0);
            animation.Play("Walk_Left");
            PrevVel = CurrentVel;
        }
        else
        {
            CurrentVel.Set(0, 0, 0);
            if (PrevVel.x < 0)
            {
                animation.Play("Idle_Left");
            }
            else
            {
                animation.Play("Idle_Right");
            }
        }
    }
}
