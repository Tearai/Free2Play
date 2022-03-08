using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

//game status data structure
[Serializable]
public struct GameStatus
{
	public string playerName;
	public int currentLevel;
	public string spawnPoint;
	public int health;
	public int coins;
}

public class Scene3_Script1 : MonoBehaviour
{

	GameStatus gameStatus;
	string filePath;
	const string FILE_NAME = "SaveStatus.json";

	//build our UI controls- a simple label
	void ShowStatus ()
	{
		//building the formatted string to be shown to the user
		string message = "";
		//message += "Player Name: " + gameStatus.playerName + "\n";
		message += "Floor: " + gameStatus.currentLevel + "\n";
		message += "Spawn Point: " + gameStatus.spawnPoint + "\n";
		message += "Health: " + gameStatus.health + "\n";
		message += "Coins: " + gameStatus.coins + "\n";

		GetComponent<Text> ().text = message;
	}

	//this function emulates a random game event that changes the player's statistics
	public void RandomiseGameStatus ()
	{
		//the namespace was specified to avoid conflicts (System.Random vs UnityEngine.Random)
		gameStatus.coins += (int)Mathf.Floor (UnityEngine.Random.Range (1.0f, 20.0f));
		gameStatus.currentLevel++;
		//simulates a level up
		if (gameStatus.coins > 100000) {
			gameStatus.currentLevel++;
			gameStatus.health += 0;
			//gameStatus.coins = 0;
		}
	}

	//this function overrides the saving file
	public void SaveGameStatus ()
	{
		//serialise the GameStatus struct into a Json string
		string gameStatusJson = JsonUtility.ToJson (gameStatus);
		//write a text file containing the string value as simple text
		File.WriteAllText (filePath + "/" + FILE_NAME, gameStatusJson);
		Debug.Log ("File created and saved");
	}

	//this function loads a saving file if found
	public void LoadGameStatus ()
	{
		//always check the file exists
		if (File.Exists (filePath + "/" + FILE_NAME)) {
			//load the file content as string
			string loadedJson = File.ReadAllText (filePath + "/" + FILE_NAME);
			//deserialise the loaded string into a GameStatus struct
			gameStatus = JsonUtility.FromJson<GameStatus> (loadedJson);
			Debug.Log ("File loaded successfully");
		} else {
			//initilise a new game status
			gameStatus.playerName = "Keith";
			gameStatus.currentLevel = 1;
			gameStatus.spawnPoint = "Beginning";//reference to a game object
			gameStatus.health = 100;
			gameStatus.coins = 0;
			Debug.Log ("File not found");
		}
	}

	// Use this for initialization
	void Start ()
	{
		//retrieving saving location
		filePath = Application.persistentDataPath;
		gameStatus = new GameStatus ();
		Debug.Log (filePath);
		//startup initialisation
		LoadGameStatus ();
	}

	// Update is called once per frame
	void Update ()
	{
		ShowStatus ();
	}

}