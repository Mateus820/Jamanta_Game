using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

	public PlayerCode playe;
	public Rigidbody2D playerRb;
	public string FILE_PATH = "saveGameData.dat";

	//Singleton;
	void Awake() {
		if(instance == null){
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else if(instance != this){
			Destroy(gameObject);
		}
	}

	//Game mode to save and load;
	void OnEnable() {
		
		print(PlayerPrefs.GetInt("Mode"));

		if(PlayerPrefs.GetInt("Mode") == 0){
			SaveGame();
		}
		else if(PlayerPrefs.GetInt("Mode") == 1){
			LoadGame();
		}
	}

	//Save game in a binary file;
	public void SaveGame()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Path.Combine(Application.streamingAssetsPath, FILE_PATH));

		SaveGameData save = new SaveGameData();

		save.posX = playerRb.position.x;
		save.posY = playerRb.position.y;

		print(playerRb.position.x);
		print(playerRb.position.y);

		bf.Serialize(file, save);
		file.Close();

	}
	public void LoadGame()
	{
		print("Loaded!");
		if (File.Exists(Path.Combine(Application.streamingAssetsPath, FILE_PATH))){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Path.Combine(Application.streamingAssetsPath, FILE_PATH), FileMode.Open);

			SaveGameData save = (SaveGameData) bf.Deserialize(file);

			file.Close();

			Vector2 playerPosition = new Vector2(save.posX, save.posY);
			playerRb.position = playerPosition;
			print(playerPosition);
		}
	}
	
	void OnApplicationQuit() {
		//SaveGame();
		//print("Jogo Salvo");
	}
}
