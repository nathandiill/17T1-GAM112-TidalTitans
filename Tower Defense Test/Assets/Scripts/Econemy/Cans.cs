using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cans : MonoBehaviour {
    // UI
    // Reusable function to get money

    public static Cans Instance;

    void Awake()
    {
        Instance = this;
    }

    public int CurrentCans = 10;
    

    void getCurrency(int CurrentCans, int GainCans)
    {
        CurrentCans = CurrentCans + GainCans;
    }

    void loseCurrency(int CurrentCans, int LoseCans)
    {
        CurrentCans = CurrentCans - LoseCans;
    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
}
