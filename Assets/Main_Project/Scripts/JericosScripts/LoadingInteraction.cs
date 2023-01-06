using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingInteraction : RepairMe
{
	public Image LoadingBar;

	private void Awake()
	{
	}
	void Update ()
	{ 
		LoadingBar.fillAmount = GetPercentage() / 100;
	}
}