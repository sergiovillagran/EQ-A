using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetaGameController : GameComponent {
    private GameObject menu;
    private GameObject game;

    Button playButton;
    Button settingsButton;
    Button exitButton;

    public MetaGameController(GameObject menu, GameObject game)
    {
        this.menu = menu;
        this.game = game; 
        playButton = menu.transform.FindChild("PlayButton").GetComponent<Button>();
        settingsButton = menu.transform.FindChild("SettingsButton").GetComponent<Button>();
        exitButton = menu.transform.FindChild("ExitButton").GetComponent<Button>();
    }

    public MetaGameController(GameObject playButton, GameObject settingsButton, GameObject exitButton)
    {
        this.playButton = playButton.GetComponent<Button>();
        this.settingsButton = settingsButton.GetComponent<Button>();
        this.exitButton = exitButton.GetComponent<Button>();
    }

    public void awake()
    {
        playButton.onClick.AddListener(play);
        settingsButton.onClick.AddListener(settings);
        exitButton.onClick.AddListener(exit);
    }

    public void start()
    {
        throw new NotImplementedException();
    }

    public void update()
    {
        throw new NotImplementedException();
    }

    private void play()
    {
        Debug.Log("press Play");
        destroy();
        game.GetComponent<Game>().chargeGame();
    }

    private void settings()
    {
        Game.GAME_STATUS = "inPlay";
    }

    private void exit()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }
    
    public void destroy()
    {
        GameObject.DestroyImmediate(menu);
    }
}
