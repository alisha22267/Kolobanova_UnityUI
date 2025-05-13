using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyes_scripts : MonoBehaviour
{
    public GameObject dark_green;
    public GameObject light_green;
    public GameObject blue;
    public GameObject purple;
    public GameObject red;
    public GameObject pink;
    public GameObject dark_orange;
    public GameObject orange;

    public GameObject dark_green_button;
    public GameObject light_green_button;
    public GameObject blue_button;
    public GameObject purple_button;
    public GameObject red_button;
    public GameObject pink_button;
    public GameObject dark_orange_button;
    public GameObject orange_button;

    public GameObject mainButton;

    public bool panelVisible = false;

    void Start()
    {
        mainButton.SetActive(true);

        dark_green_button.SetActive(false);
        light_green_button.SetActive(false);
        blue_button.SetActive(false);
        purple_button.SetActive(false);
        red_button.SetActive(false);
        pink_button.SetActive(false);
        dark_orange_button.SetActive(false);
        orange_button.SetActive(false);

        dark_green.SetActive(false);
        light_green.SetActive(false);
        blue.SetActive(false);
        purple.SetActive(false);
        red.SetActive(false);
        pink.SetActive(false);
        dark_orange.SetActive(false);
        orange.SetActive(false);
    }

    public void OnMainButtonPressed()
    {
        panelVisible = !panelVisible;

        if (panelVisible)
        {
            dark_green_button.SetActive(true);
            light_green_button.SetActive(true);
            blue_button.SetActive(true);
            purple_button.SetActive(true);
            red_button.SetActive(true);
            pink_button.SetActive(true);
            dark_orange_button.SetActive(true);
            orange_button.SetActive(true);
        }
        else
        {
            dark_green_button.SetActive(false);
            light_green_button.SetActive(false);
            blue_button.SetActive(false);
            purple_button.SetActive(false);
            red_button.SetActive(false);
            pink_button.SetActive(false);
            dark_orange_button.SetActive(false);
            orange_button.SetActive(false);
        }
    }

    void HideAllExcept(GameObject active)
    {
        if (dark_green != active) dark_green.SetActive(false);
        if (light_green != active) light_green.SetActive(false);
        if (blue != active) blue.SetActive(false);
        if (purple != active) purple.SetActive(false);
        if (red != active) red.SetActive(false);
        if (pink != active) pink.SetActive(false);
        if (dark_orange != active) dark_orange.SetActive(false);
        if (orange != active) orange.SetActive(false);
    }

    public void ShowDarkGreen()
    {
        if (dark_green.activeSelf)
            dark_green.SetActive(false);
        else
        {
            HideAllExcept(dark_green);
            dark_green.SetActive(true);
        }
    }

    public void ShowLightGreen()
    {
        if (light_green.activeSelf)
            light_green.SetActive(false);
        else
        {
            HideAllExcept(light_green);
            light_green.SetActive(true);
        }
    }

    public void ShowBlue()
    {
        if (blue.activeSelf)
            blue.SetActive(false);
        else
        {
            HideAllExcept(blue);
            blue.SetActive(true);
        }
    }

    public void ShowPurple()
    {
        if (purple.activeSelf)
            purple.SetActive(false);
        else
        {
            HideAllExcept(purple);
            purple.SetActive(true);
        }
    }

    public void ShowRed()
    {
        if (red.activeSelf)
            red.SetActive(false);
        else
        {
            HideAllExcept(red);
            red.SetActive(true);
        }
    }

    public void ShowPink()
    {
        if (pink.activeSelf)
            pink.SetActive(false);
        else
        {
            HideAllExcept(pink);
            pink.SetActive(true);
        }
    }

    public void ShowDarkOrange()
    {
        if (dark_orange.activeSelf)
            dark_orange.SetActive(false);
        else
        {
            HideAllExcept(dark_orange);
            dark_orange.SetActive(true);
        }
    }

    public void ShowOrange()
    {
        if (orange.activeSelf)
            orange.SetActive(false);
        else
        {
            HideAllExcept(orange);
            orange.SetActive(true);
        }
    }
}
