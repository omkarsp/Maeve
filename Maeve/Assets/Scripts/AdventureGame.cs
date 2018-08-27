using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    [SerializeField] State[] nextStates;
    // Use this for initialization
    State state;
    void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        Manage();
    }

    private void Manage()
    {
        var nextStates = state.GetNextStates();
        
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }
        textComponent.text = state.GetStateStory();
    }  
}
