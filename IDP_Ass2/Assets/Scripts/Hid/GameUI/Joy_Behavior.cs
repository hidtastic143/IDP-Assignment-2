﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Joy_Behavior : MonoBehaviour, IDragHandler, IPointerUpHandler,IPointerDownHandler {

    private Image JoyBG;
    private Image JoyFG;

    public Vector3 InputDirection { set; get; }

    private void Start()
    {
        JoyBG = GetComponent<Image>();
        JoyFG = transform.GetChild(0).GetComponent<Image>();
        InputDirection = Vector3.zero;
    }

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos = Vector2.zero;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(JoyBG.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / JoyBG.rectTransform.sizeDelta.x);
            pos.y = (pos.y / JoyBG.rectTransform.sizeDelta.y);

            float x = (JoyBG.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (JoyBG.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            InputDirection = new Vector3(x, y, 0);
            InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;

            JoyFG.rectTransform.anchoredPosition = new Vector3(InputDirection.x * (JoyBG.rectTransform.sizeDelta.x / 3), InputDirection.y * (JoyBG.rectTransform.sizeDelta.y / 3));
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        InputDirection = Vector3.zero;
        JoyFG.rectTransform.anchoredPosition = Vector3.zero;
    }

}
