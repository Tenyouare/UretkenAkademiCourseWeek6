using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Odev : MonoBehaviour
{
    public GameObject Panel;
    public TMP_Text TmMetin;
    public TMP_Text TmMetin1;
    public TMP_Text TmMetin2;
    public TMP_Text TmMetin3;
    public TMP_Text TmMetin4;
    public TMP_Text TmMetin5;
    public TMP_Text TmMetin6;
    string listeStringInputName = "";
    string listeStringInputAge = "";
    string listeStringInputCountry = "";
    string listeStringToggle = "";
    string listeStringExperience = "";
    string listeStringVehicle = "";
    string listeStringInputModel = "";

    public void Start()
    {
        Panel.gameObject.SetActive(false);
    }


    public void YeniEkran()
    {
        SceneManager.LoadScene(1);
    }

    public void IlkEkranaDon()
    {
        SceneManager.LoadScene(0);
    }

    public void Musait(bool TiklandiMi)
    {
        if (TiklandiMi)
        {
            listeStringToggle = "Available on weekends";
        }
        else
        {
            listeStringToggle = "Not available on weekends";
        }
    }

    public void OnEndEdit(string metinselDeger)
    {
        print(metinselDeger);
    }

    public void OnEndEditName(string metinselDeger)
    {
        listeStringInputName += "" + metinselDeger;
    }

    public void OnEndEditAge(string metinselDeger)
    {
        listeStringInputAge += "" + metinselDeger;
    }

    public void OnEndEditCountry(string metinselDeger)
    {
        listeStringInputCountry += "" + metinselDeger;
    }

    public void On_Value_Changed(float value)
    {
        listeStringExperience = "" +value;
    }

    public void DropdownValue(int sayi)
    {
        if (sayi == 0)
        {
            listeStringVehicle = "No Vehicle Information";
        }
        if (sayi == 1)
        {
            listeStringVehicle = "Mazda";
        }
        if (sayi == 2)
        {
            listeStringVehicle = "Toyota";
        }
        if (sayi == 3)
        {
            listeStringVehicle = "Honda";
        }
        if (sayi == 4)
        {
            listeStringVehicle = "Nissan";
        }
        if (sayi == 5)
        {
            listeStringVehicle = "Isuzu";
        }
        if (sayi == 6)
        {
            listeStringVehicle = "Subaru";
        }
        if (sayi == 7)
        {
            listeStringVehicle = "Mitsubishi";
        }
        if (sayi == 8)
        {
            listeStringVehicle = "Lexus";
        }
        if (sayi == 9)
        {
            listeStringVehicle = "Suzuki";
        }

    }

    public void OnEndEditModel(string metinselDeger)
    {
        listeStringInputModel += "" + metinselDeger;
    }





    public void Yazdýr()
    {
        
        print(listeStringToggle);
        print(listeStringInputName);
        print(listeStringInputAge);
        print(listeStringInputCountry);
        Panel.gameObject.SetActive(true);
        TmMetin.text = "Your Name : " + listeStringInputName;
        TmMetin1.text = "Your Age : " + listeStringInputAge;
        TmMetin2.text = "Your Country : " + listeStringInputCountry;
        TmMetin3.text = "Weekends : " + listeStringToggle;
        TmMetin4.text = "Experience : " + listeStringExperience + "/100";
        TmMetin5.text = "Brand : " + listeStringVehicle;
        TmMetin6.text = "Your Car : " + listeStringInputModel;

    }

    public void ExitBtnPanel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitBtnKayýtEkran()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitBtnAnaEkran()
    {
        Application.Quit();
    }

}
