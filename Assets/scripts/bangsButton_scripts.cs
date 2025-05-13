using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bangsButton_scripts : MonoBehaviour
{
    public GameObject bangs1_button;
    public GameObject bangs2_button;
    public GameObject bangs3_button;
    public GameObject bangs4_button;

    public GameObject mainButton;

    private bool buttonsVisible = false;

    void Start()
    {
        mainButton.SetActive(true);

        bangs1_button.SetActive(false);
        bangs2_button.SetActive(false);
        bangs3_button.SetActive(false);
        bangs4_button.SetActive(false);
    }

    public void OnMainButtonPressed()
    {
        buttonsVisible = !buttonsVisible;

        bangs1_button.SetActive(buttonsVisible);
        bangs2_button.SetActive(buttonsVisible);
        bangs3_button.SetActive(buttonsVisible);
        bangs4_button.SetActive(buttonsVisible);
    }

    void HideOtherBangsButtons(GameObject activeButton)
    {
        if (bangs1_button != activeButton) bangs1_button.SetActive(false);
        if (bangs2_button != activeButton) bangs2_button.SetActive(false);
        if (bangs3_button != activeButton) bangs3_button.SetActive(false);
        if (bangs4_button != activeButton) bangs4_button.SetActive(false);
    }

    public void ShowBangs1()
    {
        HideOtherBangsButtons(bangs1_button);
    }

    public void ShowBangs2()
    {
        HideOtherBangsButtons(bangs2_button);
    }

    public void ShowBangs3()
    {
        HideOtherBangsButtons(bangs3_button);
    }

    public void ShowBangs4()
    {
        HideOtherBangsButtons(bangs4_button);
    }
}
