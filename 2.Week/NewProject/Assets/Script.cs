using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    void Start()
    {
        bolenleriBulma(1,20);
    }

    void bolenleriBulma(int sayi1,int sayi2)
    {
        ArrayList sayiDizisi = new ArrayList();
        string sayilar = "Sayilarin Tamami:";
        string sayilar2yebolunen = "2 ye Bolunen Sayilar:";
        string sayilar3yebolunen = "3 ye Bolunen Sayilar:";
        string sayilar4yebolunen = "4 ye Bolunen Sayilar:";
        string sayilar5yebolunen = "5 ye Bolunen Sayilar:";


        for (int i = sayi1; i <= sayi2; i++)
        {
            sayiDizisi.Add(i);
        }
        foreach (int eleman in sayiDizisi)
        {
            sayilar += " " + eleman;
            if(eleman % 2 == 0)
            {
                sayilar2yebolunen += " " + eleman;
            }
            if(eleman % 3 == 0)
            {
                sayilar3yebolunen += " " + eleman;
            }
            if (eleman % 4 == 0)
            {
                sayilar4yebolunen += " " + eleman;
            }
            if (eleman % 5 == 0)
            {
                sayilar5yebolunen += " " + eleman;
            }
        }
        print(sayilar);
        print(sayilar2yebolunen);
        print(sayilar3yebolunen);
        print(sayilar4yebolunen);
        print(sayilar5yebolunen);

    }
}
