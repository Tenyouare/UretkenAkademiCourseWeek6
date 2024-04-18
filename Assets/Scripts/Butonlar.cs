using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Butonlar : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject panel;
    public void CikisButonu()
    {
        print("Oyundan ��k�ld�");
        Application.Quit();
    }

    public void YeniOyun()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("YeniOyun");
    }

    public void AnaSayfa()
    {
        SceneManager.LoadScene(0);
    }

    public void On_Value_Changed(float deger)
    {
        print(deger);
    }

    public void ToogleEnabled(bool TiklandiMi)
    {
        if (TiklandiMi)
        {
            print("Ses Aktif");
        }
        else
        {
            print("Ses Aktif De�il");
        }
    }

    public void OnEndEdit(string metinselDeger)
    {
        print("Metin : " +  metinselDeger);
    }

    public void DropdownValue(int sayi)
    {
        if (sayi == 0)
        {
            print("Araba al�m�");
        }
        else if (sayi == 1)
        {
            print("Ev al�m�");
        }
        else if (sayi == 2)
        {
            print("Arsa al�m�");
        }
    }

    public void OyunaDon()
    {
        panel.gameObject.SetActive(false);
    }

}
