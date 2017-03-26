using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    //static means variable will belong to class itself, rather than an instance of the class
    public BoardManager boardScript;

    private int level = 3;

	// Use this for initialization
	void Awake () {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        boardScript = GetComponent<BoardManager>();
        InitGame();
		
	}

    void InitGame()
    {
        boardScript.SetupScene(level);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
