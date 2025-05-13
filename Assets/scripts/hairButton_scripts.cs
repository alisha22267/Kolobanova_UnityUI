using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairButton_scripts : MonoBehaviour
{
    public GameObject hair1_button;
    public GameObject hair2_button;
    public GameObject hair3_button;
    public GameObject hair4_button;

    public GameObject mainButton;

    private bool buttonsVisible = false;

    void Start()
    {
        mainButton.SetActive(true);

        hair1_button.SetActive(false);
        hair2_button.SetActive(false);
        hair3_button.SetActive(false);
        hair4_button.SetActive(false);
    }

    public void OnMainButtonPressed()
    {
        buttonsVisible = !buttonsVisible;

        hair1_button.SetActive(buttonsVisible);
        hair2_button.SetActive(buttonsVisible);
        hair3_button.SetActive(buttonsVisible);
        hair4_button.SetActive(buttonsVisible);
    }

    void HideOtherHairButtons(GameObject activeButton)
    {
        if (hair1_button != activeButton) hair1_button.SetActive(false);
        if (hair2_button != activeButton) hair2_button.SetActive(false);
        if (hair3_button != activeButton) hair3_button.SetActive(false);
        if (hair4_button != activeButton) hair4_button.SetActive(false);
    }

    public void ShowHair1()
    {
        HideOtherHairButtons(hair1_button);
    }

    public void ShowHair2()
    {
        HideOtherHairButtons(hair2_button);
    }

    public void ShowHair3()
    {
        HideOtherHairButtons(hair3_button);
    }

    public void ShowHair4()
    {
        HideOtherHairButtons(hair4_button);
    }
}
