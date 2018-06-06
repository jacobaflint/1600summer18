using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBehavior : MonoBehaviour {

    public ChangeUIColor ChangeColor;

	void Start () {
        ChangeColor.ColorUI( GetComponent<Image>() );
	}
	
}
