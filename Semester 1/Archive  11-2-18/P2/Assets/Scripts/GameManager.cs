using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager
{
    static GameManager instance;

    public static GameManager Instance
    { get { return instance ?? ((instance = new GameManager())); } }

    public Character Character
    {
        get; set;
    }

    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }

    private void Update()
    {

    }

    public class Updater
    {

        // Use this for initialization
        private void Update()
        {
            Instance.Update();
        }

        // Update is called once per frame

    }
}
