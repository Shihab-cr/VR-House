using TMPro;
using UnityEngine;

public class goalHandler : MonoBehaviour
{
    public TextMeshProUGUI goalText;
    //public GameObject basketBall;
    private int goalsScored = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("basketball"))
        {
            goalsScored++;
            goalText.text = "Score: " + goalsScored;
            // Optionally, you can add code here to reset the ball's position or play a sound effect
        }
    }
}
