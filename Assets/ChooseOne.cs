using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseOne : MonoBehaviour
{
    //[SerializeField] SpriteRenderer sr;
    public bool clickable = false;
    public static ChooseOne oneInst;
    Image screen;

    // Start is called before the first frame update
    void Start()
    {
        oneInst = this;
        screen = GameObject.FindGameObjectWithTag("Screen").GetComponent<Image>();
    }

    //private void OnMouseEnter()
    //{
    //    Debug.Log("Enter!");
    //    sr.color = new Color(1f, 1f, 1f, 0.5f);
    //}

    //private void OnMouseExit()
    //{
    //    Debug.Log("Leave!");
    //    sr.color = new Color(1f, 1f, 1f, 1f);
    //}

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Choose") == 1)
        {
            GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = "";
            GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = "";
            RootManager.rootInstance.Choose = false;
            PlayerPrefs.SetInt("Choose", 0);

            //root1
            switch (RootManager.rootInstance.CurrentRoot)
            {
                case 0:
                    //Отобразить картинку AEE9
                    screen.sprite = RootManager.rootInstance.img7;
                    RootManager.rootInstance.CurrentRoot = 1;
                    PlayerPrefs.SetInt("CurrentRoot", 1);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Root1String0"));
                    break;
                case 1:
                    RootManager.rootInstance.CurrentRoot = 2;
                    PlayerPrefs.SetInt("CurrentRoot", 2);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Root2String0"));
                    break;
                case 2:
                    //dead
                    RootManager.rootInstance.CurrentRoot = 10;
                    PlayerPrefs.SetInt("CurrentRoot", 10);
                    TextWriter.StartWriting(PlayerPrefs.GetString("WrongChoice2String0"));
                    break;
                case 3:
                    //First final
                    RootManager.rootInstance.CurrentRoot = 11;
                    PlayerPrefs.SetInt("CurrentRoot", 11);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Final1String0"));
                    break;
                case 4:
                    //dead
                    RootManager.rootInstance.CurrentRoot = 10;
                    PlayerPrefs.SetInt("CurrentRoot", 10);
                    TextWriter.StartWriting(PlayerPrefs.GetString("WrongChoice3String0"));
                    break;
                case 5:
                    //Отобразить картинку B8D3
                    screen.sprite = RootManager.rootInstance.img8;
                    RootManager.rootInstance.CurrentRoot = 6;
                    PlayerPrefs.SetInt("CurrentRoot", 6);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Root6String0"));
                    break;
                case 6:
                    //Fourth final
                    RootManager.rootInstance.CurrentRoot = 14;
                    PlayerPrefs.SetInt("CurrentRoot", 14);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Final4String0"));
                    break;
            }

            Debug.Log("Click!");
            Debug.Log(PlayerPrefs.GetInt("CurrentRoot"));

            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Choose") == 1)
        {
            switch (PlayerPrefs.GetInt("CurrentRoot"))
            {
                case 0:
                    GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot1");
                    break;
                case 1:
                    GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot3");
                    break;
                case 2:
                    //death
                    GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot6");
                    break;
                case 3:
                    //First final
                    GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot7");
                    break;
                case 4:
                    //death
                    GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot10");
                    break;
                case 5:
                    GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot11");
                    break;
                case 6:
                    //Fourth final
                    GameObject.FindGameObjectWithTag("TextOne").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot13");
                    break;
            }
        }
    }
}
