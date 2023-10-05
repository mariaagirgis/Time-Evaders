using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FlashingText : MonoBehaviour
{
    private Text flashingText;
    private Color color1 = Color.red;
    private Color color2 = Color.blue;

    private void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(Flashing());
    }

    private IEnumerator Flashing()
    {
        while (true)
        {
            flashingText.color = color1;
            yield return new WaitForSeconds(0.5f);
            flashingText.color = color2;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
