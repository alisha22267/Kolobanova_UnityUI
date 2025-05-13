using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHair_scripts : MonoBehaviour
{
    public GameObject scaleSlider;
    public GameObject scaleUP;
    public GameObject rotationSlider;
    public GameObject[] imageFields = new GameObject[10];

    private bool slidersVisible = false;

    void Start()
    {
        scaleSlider.SetActive(false);
        rotationSlider.SetActive(false);
        scaleUP.SetActive(false);
    }

    public void ChangeUP()
    {
        float currentScale = scaleUP.GetComponent<Slider>().value;
        foreach (GameObject imageField in imageFields)
        {
            imageField.transform.localScale = new Vector2(1F * currentScale, 1F * currentScale);
        }
    }

    public void PogaMain()
    {
        slidersVisible = !slidersVisible;
        scaleSlider.SetActive(slidersVisible);
        rotationSlider.SetActive(slidersVisible);
        scaleUP.SetActive(slidersVisible);
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
