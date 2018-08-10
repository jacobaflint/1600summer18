using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour {

    public FloatData HealthLevel;
    public FloatData EvilPower;


	void Start () {
		
	}
	
	
	void OnTriggerEnter () {
		if (HealthLevel.Value > 0)
		{
			HealthLevel.Value -= EvilPower.Value;
		}
			
	}

	private void OnDisable()
	{
		HealthLevel.Value = 1;
	}
}
