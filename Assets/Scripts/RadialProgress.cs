using UnityEngine;
using UnityEngine.UI;
using System.Collections;  
using System.Collections.Generic; 
using TMPro;

 
public class RadialProgress : MonoBehaviour {
	public TMP_Text ProgressIndicator;
	public Image LoadingBar;
	float currentValue;
	public float speed;
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (currentValue < 100) {
			currentValue += speed * Time.deltaTime;
			ProgressIndicator.text = ((int)currentValue).ToString () + "%";
		} else {
			ProgressIndicator.text = "Done";
		}
 
		LoadingBar.fillAmount = currentValue / 100;
	}
}