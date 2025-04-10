using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartGame : MonoBehaviour
{
    private const string LABYRINTH_SCENE = "Labyrinthe";


    // Press ENTER to start the game
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    // Towards the labyrinth scene
    public void StartGame()
    {
        SceneManager.LoadScene(LABYRINTH_SCENE);
    }
}
