using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model: iModel {

    int lives = 0;
    public Player player;

    public Model () {
        int lives = 5;
        player = new Player();
	}

    public void update() { }

}
