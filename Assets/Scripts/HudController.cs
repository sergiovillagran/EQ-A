using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : GameComponent{
    private GameObject game;
    private GameObject HUD;
    private GameObject tutorial;

    private GameObject maingame;
    private GameObject menuCamera;

    Button menuButton;
    Button tutorialPlayButton;
    
    public HudController(GameObject HUD, GameObject game, GameObject tutorial, GameObject menuCamera)
    {
        this.game   = game;
        this.HUD    = HUD;
        menuButton  = HUD.transform.Find("Canvas/MenuButton").GetComponent<Button>();

        this.tutorial    = tutorial;
        tutorialPlayButton = tutorial.transform.Find("tutoButton").GetComponent<Button>();
        this.menuCamera = menuCamera;
    }

    public void awake()
    {
        Debug.Log("si paso por aca");

        menuButton.onClick.AddListener(backToMainMenu);
        tutorialPlayButton.onClick.AddListener(hideTuto);

        if (HUD)
        {
            HUD.SetActive(false);
            maingame = GameObject.Find("MainGame(Clone)");
            maingame.SetActive(false);
            menuCamera.SetActive(true);
        }
    }

    public void hideTuto ()
    {
        tutorial.SetActive(false);
        HUD.SetActive(true);
        menuCamera.SetActive(false);
        maingame.SetActive(true);
    }

    public void destroy()
    {
        GameObject.DestroyImmediate(HUD);
    }

    public void start()
    {
        throw new NotImplementedException();
    }

    public void update()
    {
        throw new NotImplementedException();
    }

    private void backToMainMenu()
    {
        destroy();
        game.GetComponent<Game>().chargeMenu();
    }
}
