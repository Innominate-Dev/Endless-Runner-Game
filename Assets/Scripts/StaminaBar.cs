using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider staminaBar;

    private int MaxStamina = 10000;
    private int currentStamina;
    
    public static StaminaBar Instance;
    
    private void Awake()
    {
        Instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        currentStamina = MaxStamina;
        staminaBar.maxValue = MaxStamina;
        staminaBar.value = MaxStamina;
    }

    public void UseStamina(int amount)
    {
        if(currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;
        }
        else
        {
            Debug.Log("Not Enough Stamina");
        }
    }

    public void GiveStamina (int amount)
    {
        currentStamina = currentStamina + amount;
        staminaBar.value = currentStamina;
        Debug.Log("Giving Stamina!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
