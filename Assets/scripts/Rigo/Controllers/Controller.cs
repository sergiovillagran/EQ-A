using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private Controller() {
		
	}
    
    public void update() {
        
    }


    #region Singleton + Lazy
    private static bool wasDelivered = false;
    private static Controller instance = null;

    public static Controller getInstance()
    {
        if (wasDelivered == false)
        {
            if (instance == null)
            {
                wasDelivered = true;
                instance = new Controller();
            }
            return instance;
        }
        else
        {
            return null;
        }

    }
    #endregion

}
