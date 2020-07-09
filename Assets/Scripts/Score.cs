using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform obstacle; // can be any obstacle as they all move the same
    public Text scoreText;
    private float startingZ;

    // Called when the game starts
    void Start() {
        // record the starting z-coordinate
        startingZ = obstacle.position.z;
    }

    // Called once per frame
    void Update() {
        // Note that the obstacle's z coordinate will decrease with time
        scoreText.text = (startingZ - obstacle.position.z).ToString("0");
    }
}
