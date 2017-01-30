using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameComponent {
	void start();
	void update();
	void awake();
    void destroy();
}
