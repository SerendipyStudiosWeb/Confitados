﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Text cookies;
    public Text chocolates;

    private void Start()
    {
        cookies.text = PlayerPrefs.GetInt("Cookies", 0).ToString();
        chocolates.text = PlayerPrefs.GetInt("Chocolates", 0).ToString();
    }
}