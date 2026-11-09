    
using UnityEngine;

    [Header("UI References")]
using UnityEngine.UI;
public class GameManager : MonoBehaviour
    public Text scoreText;
{
    public GameObject gameOverPanel;
    public static GameManager Instance;

    [Header("Game Settings")]
    public int score = 0;
    public int selectedSkinIndex = 0; // 0 to 9 (10 Skins)
    
    // Inspector mein 10 Materials assign karein
    public Material[] snakeSkins = new Material[10]; 

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
