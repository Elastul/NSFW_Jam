using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTwo : MonoBehaviour
{
    //[SerializeField] SpriteRenderer sr;
    public bool clickable = false;
    public static ChooseTwo twoInst;
    Image screen;

    // Start is called before the first frame update
    void Start()
    {
        twoInst = this;
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
        //if (PlayerPrefs.GetInt("Choose") == 1)
        //{
        //    Debug.Log("Click!");
        //    //PlayerPrefs.SetInt("CurrentRoot", PlayerPrefs.GetInt("CurrentRoot") + 1);
        //    Debug.Log(PlayerPrefs.GetInt("CurrentRoot"));

        //    PlayerPrefs.Save();
        //}
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
                    //Отобразить картинку 9E4E
                    screen.sprite = RootManager.rootInstance.img3;
                    RootManager.rootInstance.CurrentRoot = 4;
                    PlayerPrefs.SetInt("CurrentRoot", 4);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Root4String0"));
                    break;
                case 1:
                    //dead
                    RootManager.rootInstance.CurrentRoot = 10;
                    PlayerPrefs.SetInt("CurrentRoot", 10);
                    TextWriter.StartWriting(PlayerPrefs.GetString("WrongChoice1String0"));
                    break;
                case 2:
                    //Отобразить картинку E707
                    screen.sprite = RootManager.rootInstance.img12;
                    RootManager.rootInstance.CurrentRoot = 3;
                    PlayerPrefs.SetInt("CurrentRoot", 3);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Root3String0"));
                    break;
                case 3:
                    //Second final
                    RootManager.rootInstance.CurrentRoot = 12;
                    PlayerPrefs.SetInt("CurrentRoot", 12);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Final2String0"));
                    break;
                case 4:
                    //Отобразить картинку 2DD4
                    screen.sprite = RootManager.rootInstance.img2;
                    RootManager.rootInstance.CurrentRoot = 5;
                    PlayerPrefs.SetInt("CurrentRoot", 5);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Root5String0"));
                    break;
                case 5:
                    //dead
                    RootManager.rootInstance.CurrentRoot = 10;
                    PlayerPrefs.SetInt("CurrentRoot", 10);
                    TextWriter.StartWriting(PlayerPrefs.GetString("WrongChoice4String0"));
                    break;
                case 6:
                    //Third final
                    RootManager.rootInstance.CurrentRoot = 13;
                    PlayerPrefs.SetInt("CurrentRoot", 13);
                    TextWriter.StartWriting(PlayerPrefs.GetString("Final3String0"));
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
                    GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot2");
                    break;
                case 1:
                    //death
                    GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot4");
                    break;
                case 2:
                    GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot5");
                    break;
                case 3:
                    //Second final
                    GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot8");
                    break;
                case 4:
                    GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot9");
                    break;
                case 5:
                    //death
                    GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot12");
                    break;
                case 6:
                    //Third final
                    GameObject.FindGameObjectWithTag("TextTwo").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("TextRoot14");
                    break;
            }
        }
    }
}
