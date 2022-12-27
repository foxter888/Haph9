using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingInteraction : RepairMe
{
	public Image LoadingBar;
	float currentValue;

	private void Awake()
	{
		currentValue = 0;
	}
	void Update ()
	{ 
		LoadingBar.fillAmount = GetPercentage() / 100;
	}
}