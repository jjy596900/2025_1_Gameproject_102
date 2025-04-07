using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives = 1;


    public float invincibleTime = 1.0f;
    public bool islnvincible = false;
    // Start is called before the first frame update
    void Start()
    {
        currentLives = maxLives;
    }

    void OnTriggerEnther(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            currentLives--;
            Destroy(other.gameObject);

            if (currentLives <= 0) 
            {
                GameOver();
            }
        }
    }

    public void GameOver() 
    {
        gameObject.SetActive(false);
        Invoke("ResartGame", 3.0f);

    }

    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
