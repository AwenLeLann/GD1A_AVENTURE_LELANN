using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfFullHeart;
    public Sprite emptyHeart;
    public FloatValue heartContainers;
    public FloatValue playerCurrenthealth;

    // Start is called before the first frame update
    void Start()
    {
        InitHeart();
    }
    public void InitHeart()
    {
        for(int i = 0; i < heartContainers.initialValue; i++)
        {
            hearts[i].gameObject.SetActive(true);
            hearts[i].sprite = fullHeart;
        }
    }
    public void UpdateHeart()
    {
        float tempHealth = playerCurrenthealth.RuntimeValue / 2;
        for (int i = 0; i < heartContainers.initialValue; i++)
        {
            if(i <= tempHealth - 1)
            {
                //Full Heart
                hearts[i].sprite = fullHeart;
            }else if(i > tempHealth)
            {
                hearts[i].sprite = emptyHeart;
            }
            else
            {
                //halffullheart
                hearts[i].sprite = halfFullHeart;
            }
        }
    }
}
