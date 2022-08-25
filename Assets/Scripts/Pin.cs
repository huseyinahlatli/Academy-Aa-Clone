using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pin : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Rigidbody2D _rigidbody;
    private bool isPinned = false;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(!isPinned)
            _rigidbody.MovePosition(_rigidbody.position + Vector2.up * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Rotator"))
        {
            transform.SetParent(other.transform);
            GameManager.Instance.pinCount += 1;
            // other.GetComponent<Rotator>().rotateSpeed *= -1;
            isPinned = true;
        }
        
        else if (other.CompareTag("Pin"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
