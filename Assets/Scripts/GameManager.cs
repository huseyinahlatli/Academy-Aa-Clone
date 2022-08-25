using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pinCountText;
    private bool _gameHasEnded = false;
    public Rotator rotator;
    public PinSpawner pinSpawner;
    public Animator animator;
    [FormerlySerializedAs("PinCount")] public int pinCount;
    public static GameManager Instance;
    public void Awake()
    {
        if (Instance == null)
            Instance = this;
        
        pinCount = 0;
    }

    private void Update()
    {
        pinCountText.text = pinCount.ToString();
    }

    public void EndGame()
    {
        if (_gameHasEnded)
            return;

        rotator.enabled = false;
        pinSpawner.enabled = false;

        animator.SetTrigger("EndGame");
        _gameHasEnded = true;
        print("End Game!");
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
