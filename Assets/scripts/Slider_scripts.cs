using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_scripts : MonoBehaviour
{
    public GameObject scaleSlider;
    public GameObject rotationSlider;
    public GameObject[] imageFields; 

    private bool slidersVisible = false;

    void Start()
    {
        scaleSlider.SetActive(false);
        rotationSlider.SetActive(false);
    }

    public void PogaMain()
    {
        slidersVisible = !slidersVisible;
        scaleSlider.SetActive(slidersVisible);
        rotationSlider.SetActive(slidersVisible);
    }

    public void ChangeScale()
    {
        float currentHeight = scaleSlider.GetComponent<Slider>().value;
        foreach (GameObject imageField in imageFields)
        {
            Vector3 scale = imageField.transform.localScale;
            imageField.transform.localScale = new Vector3(scale.x, currentHeight, scale.z);
        }
    }

    public void ChangeRotation()
    {
        float currentWidth = rotationSlider.GetComponent<Slider>().value;
        foreach (GameObject imageField in imageFields)
        {
            Vector3 scale = imageField.transform.localScale;
            imageField.transform.localScale = new Vector3(currentWidth, scale.y, scale.z);
        }
    }
}
