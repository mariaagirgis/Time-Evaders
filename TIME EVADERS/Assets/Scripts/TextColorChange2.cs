using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextColorChange2 : MonoBehaviour
{
    private Color normalColor;
    private Color highlightedColor;

    void Start()
    {
        normalColor = GetComponent<Text>().color;
        highlightedColor = new Color(0.2f, 0.2f, 0.2f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Text>().color = highlightedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Text>().color = normalColor;
    }
}
