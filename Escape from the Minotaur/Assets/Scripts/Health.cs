using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 100;
    public Slider mySlider;
    public Image myImage;

    void Update()
    {
        mySlider.value = health;
        if(health<10)
        {
            myImage.enabled = false;
        }
        else
        {
            myImage.enabled = true;
        }

        if(health<10)
        {
            SceneManager.LoadScene(2);
        }
    }
}
