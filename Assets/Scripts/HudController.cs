using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : GameComponent{
    private GameObject game;
    private GameObject HUD;

    Button menuButton;

    public HudController(GameObject HUD, GameObject game)
    {
        this.game   = game;
        this.HUD    = HUD;
        menuButton  = HUD.transform.Find("Canvas/MenuButton").GetComponent<Button>();
    }

    public void awake()
    {
        Debug.Log("si paso por aca");
        menuButton.onClick.AddListener(backToMainMenu);
    }

    public void destroy()
    {
        throw new NotImplementedException();
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
		GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerControl>().CalculateDamage(-1);
    }
}
