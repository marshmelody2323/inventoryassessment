using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText2 : MonoBehaviour
{
    public Text textField;

    //public string myVariable;
    //private void OnEnable()
    //{
    //    SetText(myVariable);
    //}
    public void SetText(string text)
    {
        textField.text = text;
    }

}
