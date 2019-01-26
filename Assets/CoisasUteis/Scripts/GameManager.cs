using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager game;
	public Score score;
	
	public Player player;

	public static GameManager Game {
		get {
			if (game == null) {
				game = GameObject.FindObjectOfType<GameManager>();
			}
			return game;
		}
	}
}
