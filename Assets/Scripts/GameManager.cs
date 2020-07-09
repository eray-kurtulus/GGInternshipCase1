using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    float delay = 2f; // the delay before restart (in seconds)

    public void EndGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;

            // Stop all obstacles
            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
            foreach (GameObject obstacle in obstacles) {
                obstacle.GetComponent<ObstacleMovement>().Stop();
            }

            Invoke("Restart", delay);
        }
    }

    void Restart() {
        // Restart the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
