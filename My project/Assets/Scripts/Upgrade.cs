using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public int level = 1;
    public int price= 10;
    public string description;

    public TextMeshProUGUI textLevel;
    public TextMeshProUGUI textPrice;
    public TextMeshProUGUI textDescription;

    public Button button;

    public void OnButtonClicked()
    {
        if (GameManager.Instance.currentGold >= price)
        {
            GameManager.Instance.currentGold -= price;
            level++;
            price *= 3;
            Clicked();
        }
    }
    public virtual void Clicked()
    {
        
    }

    private void Start()
    {
        textDescription.text = description;
    }

    private void Update()
    {
        textLevel.text = "Lv. " + level.ToString();
        textPrice.text = price.ToString() + " $";
    }
}
