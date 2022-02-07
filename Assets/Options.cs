using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    Slider sl;

    // Start is called before the first frame update
    void Start()
    {
        sl = GameObject.FindGameObjectWithTag("MusicSlider").GetComponent<Slider>();
        sl.value = PlayerPrefs.GetFloat("MusicVolume");
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1f);
        }
        Debug.Log(PlayerPrefs.GetFloat("MusicVolume"));
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("MusicVolume", sl.value);
        Debug.Log(PlayerPrefs.GetFloat("MusicVolume"));
    }
}
