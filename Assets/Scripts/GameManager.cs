using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        // Placeholder for starting the game
        Debug.Log("Game Started");
    }

    public void GameOver()
    {
        // Placeholder for game over logic
        Debug.Log("Game Over");
    }
}
