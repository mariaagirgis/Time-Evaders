using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextColorChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color normalColor;
    private Color highlightedColor;

    void Start()
    {
        normalColor = GetComponent<Text>().color;
        highlightedColor = new Color(0.5f, 0.5f, 0.5f);
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
