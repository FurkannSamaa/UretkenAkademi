using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject label;
    string isim;
    bool is18;
    string cinsiyet;
    public Toggle toggle;
    public InputField input;
    public Dropdown dropdown;

    public void Play()
    {

        SceneManager.LoadScene(1);

    }

    public void Setting()
    {
        label.SetActive(true);
    }

    public void Quit()
    {

        Application.Quit();

    }

    public void labelQuit()
    {
        label.SetActive(false);
    }

    public void submit()
    {
        if(toggle.isOn) {
            PlayerPrefs.SetInt("is18", 1);
        }
        else {
            PlayerPrefs.SetInt("is18", 0);
        }
        isim =input.text;
        PlayerPrefs.SetString("isim", isim);
        if (dropdown.value==0)
        {
            cinsiyet="Belirtilmemiþ";
            PlayerPrefs.SetString("cinsiyet", cinsiyet);

        }
        else if(dropdown.value==1)
        {
            cinsiyet = "Erkek";
            PlayerPrefs.SetString("cinsiyet", cinsiyet);

        }
        else
        {
            cinsiyet = "Kadýn";
            PlayerPrefs.SetString("cinsiyet", cinsiyet);

        }
    }

}
