using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	float TankInventory;
	public Text TankInventoryText;
	float Timer = 4f;
	float CurrentTimer = 0;
	bool StartTimer;
	float Throughput;
	//Throughput is in barrels per day
	//Tank inventory is in barrels

	// Use this for initialization
	void Start () {

		TankInventory = 720000;
		Throughput = 150000;

	}
	
	// Update is called once per frame
	void Update () {
		
		if (StartTimer) {
			CurrentTimer += Time.deltaTime;
			InventoryOnClick ();
		}

	}

	public void InventoryOnClick ()
	{
		Timer = Time.deltaTime;
		Debug.Log (Timer);

		if (!StartTimer) {
			StartTimer = true;
		}
		CalculateInventory ();
	}

	void CalculateInventory ()
	{
		TankInventory -= Timer * Throughput / (60 * 60 * 24);
		TankInventoryText.text = TankInventory.ToString ();
		Debug.Log (TankInventory);
	}
}
