using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown_scripts : MonoBehaviour
{
    public GameObject imageField;
    public Sprite[] soriteArray;

    public void Dropdown(int index)
    {
        if (index == 0)
            imageField.GetComponent<Image>().sprite = soriteArray[0];
        else if (index == 1)
            imageField.GetComponent<Image>().sprite = soriteArray[1];
        else if (index == 2)
            imageField.GetComponent<Image>().sprite = soriteArray[2];
        else if (index == 3)
            imageField.GetComponent<Image>().sprite = soriteArray[3];
        else if (index == 4)
            imageField.GetComponent<Image>().sprite = soriteArray[4];
        else if (index == 5)
            imageField.GetComponent<Image>().sprite = soriteArray[5];
    }
}
