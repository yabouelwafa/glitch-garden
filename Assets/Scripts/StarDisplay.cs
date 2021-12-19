﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
        Updatedisplay();
    }

    private void Updatedisplay()
    {
        starText.text = stars.ToString();

    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        Updatedisplay();
    }

    public void spendStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            Updatedisplay();
        }
    }

}