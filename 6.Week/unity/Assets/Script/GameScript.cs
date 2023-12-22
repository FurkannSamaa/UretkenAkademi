using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public Text text1,text2,text3;

    
    void Start()
    {
        text1.text = PlayerPrefs.GetString("isim");
        text2.text = PlayerPrefs.GetString("cinsiyet");
        if (PlayerPrefs.GetInt("is18") == 1)
        {
            text3.text = "Yaþýnýz 18'den Büyük";
        }
        else
        {
            text3.text = "Yaþýnýz 18'den Küçük";
        }


    }

    public void back()
    {

        SceneManager.LoadScene(0);

    }

 
}
