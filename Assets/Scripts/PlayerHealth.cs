using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Material _healthBarMat;
    public float health = 100;

    private bool IsGameOver = false;
    public GameObject GameOverUI;

    void Start()
    {
        _healthBarMat.SetFloat("_Health", health / 100);
    }

    private void Update()
    {
        if (health <= 0)
        { 
            IsGameOver = true;
            Cursor.lockState = CursorLockMode.None;

            GameOverUI.SetActive(true);
            Debug.Log("you lost");

        }
    }

    public void DecreaseHealth()
    {
        health= health- 20;
        _healthBarMat.SetFloat("_Health", health/100);
    }
}
