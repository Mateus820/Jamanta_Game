using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

	public PlayerCode player;
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
	void Start() {
		
		print(PlayerPrefs.GetInt("Mode"));

		if(PlayerPrefs.GetInt("Mode") == 1){
			LoadGame();
		}
	}

    void Update() {
        if(Input.GetKeyDown(KeyCode.P)){
            SaveGame();
        }    
    }

	//Save game in a binary file;
	public void SaveGame()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Path.Combine(Application.streamingAssetsPath, FILE_PATH));

		SaveGameData save = new SaveGameData();

        if(playerRb == null)
            playerRb = Singleton.GetInstance.playerRb;

        if(playerRb == null)
            return;

        save.posX = playerRb.position.x;
        save.posY = playerRb.position.y;

        print(playerRb.position.x);
        print(playerRb.position.y);

		bf.Serialize(file, save);
        print("Saved");
		file.Close();

	}
	public void LoadGame()
	{
        print("cool");
        if(playerRb == null)
            playerRb = Singleton.GetInstance.playerRb;

        if(playerRb == null)
            return;

		if (File.Exists(Path.Combine(Application.streamingAssetsPath, FILE_PATH))){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Path.Combine(Application.streamingAssetsPath, FILE_PATH), FileMode.Open);

			SaveGameData save = (SaveGameData) bf.Deserialize(file);
            print("Loaded!");

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
