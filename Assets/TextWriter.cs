using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TextWriter : MonoBehaviour
{
    static string currentTextString = "";
    static string textString = "";
    static bool start = false;
    static bool stop = false;
    public float delay = .025f;
    public static bool ended;

    // Start is called before the first frame update
    void Start()
    {
        ended = true;
    }

    public static void StartWriting(string textStr)
    {
        textString = textStr;
        start = true;
    }

    public static void StopWriting()
    {        
        stop = true;
    }

    private void Update()
    {
        if (stop)
        {
            stop = false;
            ended = true;
            StopAllCoroutines();
            //StopCoroutine("WriteText");
            //currentTextString = ;
            this.GetComponent<TextMeshProUGUI>().text = textString;
        }
        if (start)
        {
            start = false;
            StartCoroutine(WriteText(textString));
        }
    }

    IEnumerator WriteText(string textString)
    {
        ended = false;
        currentTextString = "";
        for (int i = 0; i <= textString.Length; i++)
        {
            currentTextString = textString.Substring(0, i);
            this.GetComponent<TextMeshProUGUI>().text = currentTextString;
            yield return new WaitForSeconds(delay);
        }
        ended = true;
    }
}
