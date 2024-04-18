using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YeniYontemler : MonoBehaviour
{
    public Slider sl;
    public TMP_Text TMmetin;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        TMmetin.text = "Merhaba Dunya";
    }

    // Update is called once per frame
    void Update()
    {
        print(sl.value);
        print(text.text);
    }
}
