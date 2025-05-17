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
    private GameObject selectedClothingItem = null;

    private bool slidersVisible = false;

    void Start()
    {
        scaleSlider.SetActive(false);
        rotationSlider.SetActive(false);
        scaleUP.SetActive(false);
    }

    public void SelectClothingItem(GameObject item)
    {
        selectedClothingItem = item;
    }

    public void ChangeUP()
    {
        if (selectedClothingItem == null) return;

        float currentScale = scaleUP.GetComponent<Slider>().value;
        selectedClothingItem.transform.localScale = new Vector2(1F * currentScale, 1F * currentScale);
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
        if (selectedClothingItem == null) return;

        float currentHeight = scaleSlider.GetComponent<Slider>().value;
        Vector3 scale = selectedClothingItem.transform.localScale;
        selectedClothingItem.transform.localScale = new Vector3(scale.x, currentHeight, scale.z);
    }

    public void ChangeRotation()
    {
        if (selectedClothingItem == null) return;

        float currentWidth = rotationSlider.GetComponent<Slider>().value;
        Vector3 scale = selectedClothingItem.transform.localScale;
        selectedClothingItem.transform.localScale = new Vector3(currentWidth, scale.y, scale.z);
    }
}
