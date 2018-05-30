using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : ScriptableObject
{
    public Animal AnyAnimal;
   [Range(0,10)] public float PowerLevel = 1.0f;
   
    public void RunPowerUp()
    {
        AnyAnimal.Health += PowerLevel;
    }
}
