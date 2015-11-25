using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShopControl : MonoBehaviour {

    private static int counter;
    public  Text Points;

	// Update is called once per frame
	void Update () {
        if (counter >=2) 
        {
            Application.LoadLevel("Shop");
        }
	}

    public static void SetCounter(int value)
    {
        counter+=value;        
    }
}
