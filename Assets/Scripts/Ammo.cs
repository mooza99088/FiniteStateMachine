using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    private int ammoCount;

    [SerializeField] Text ammoText;

    [SerializeField] InputField inputField;

    void Start()
    {
        ammoCount = 12;
        ammoText.text = "Current Ammo" + ammoCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReduceAmmo()
    {
        ammoCount -= 10;
        ammoText.text = "Current Ammo: " + ammoCount;
    }

    public void IncreaseAmmo()
    {
        ammoCount += int.Parse(inputField.text);
        ammoText.text = "current Ammo: " + ammoCount;
    }
}
