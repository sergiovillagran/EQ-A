using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public GameObject menu;
    public GameObject HUD;
    public GameObject[] gameLevels;

    public const int DEFAULT_GAME_SCENE_INDEX = 0;

    public static string GAME_STATUS;
    public static MetaGameController menuController;
    private static List<GameComponent> controllers;

    
    
    void Awake()
    {
        controllers = new List<GameComponent>();
        chargeMenu(gameObject);
        sendMessage("awake");
    }

	void Start () {
        
    }
	
	void Update () {
		
	}

    public void chargeMenu (GameObject game = null)
    {
        menu = Instantiate(menu);
        menu.transform.SetParent(game.transform);
        controllers.Add(new MetaGameController(menu, gameObject));

        GAME_STATUS = "MAIN_MENU";
    }

    public void chargeGame (GameObject game = null)
    {
        HUD = Instantiate(HUD);
        HUD.transform.SetParent(gameObject.transform);

        gameLevels[DEFAULT_GAME_SCENE_INDEX] = Instantiate(gameLevels[DEFAULT_GAME_SCENE_INDEX]);
        gameLevels[DEFAULT_GAME_SCENE_INDEX].transform.SetParent(gameObject.transform);

        menuController = null;

        GAME_STATUS = "IN_GAME";
    }

    private void sendMessage(string message)
    {
        switch (message)
        {
            case "awake":
                {
                    foreach (GameComponent go in controllers)
                    {
                        go.awake();
                    }
                    break;
                }
            case "start":
                {
                    foreach (GameComponent go in controllers)
                    {
                        go.start();
                    }
                    break;
                }
            case "destroy":
                {
                    foreach (GameComponent go in controllers)
                    {
                        go.destroy();
                    }
                    break;
                }
            case "update":
                {
                    foreach (GameComponent go in controllers)
                    {
                        go.update();
                    }
                    break;
                }
        }
    }
}
