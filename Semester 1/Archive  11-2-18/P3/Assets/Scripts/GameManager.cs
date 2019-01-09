using UnityEngine;
public class GameManager
{
    static GameManager instance;
    public static GameManager Instance
    { get { return instance ?? ((instance = new GameManager())); } }
    Vector3 velocity = new Vector3(0, 0, 0);
public Sunflower sunflower
    {
        get; set;
    }
    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }
    private void Update()
    {
        float timer = 0.0f;
        
}
    public class Updater
    {

        // Update is called once per frame
        private void Update()
        {
            Instance.Update();
        }
    }
}