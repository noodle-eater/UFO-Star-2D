using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NoodleEater
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed;

        private ScoreUI _scoreUI;
        private AudioPlayer _audioPlayer;
        
        private int _score = 0;

        private void Start()
        {
            _scoreUI = FindObjectOfType<ScoreUI>();
            _audioPlayer = FindObjectOfType<AudioPlayer>();
        }

        private void Update()
        {
            Move();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Coin coin = other.gameObject.GetComponent<Coin>();

            if (coin == null) return;
            
            _score += coin.Score;
            
            _scoreUI.SetScore(_score);
            _audioPlayer.PlayCollectCoin();
        }

        private void Move()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * (speed * Time.deltaTime));
            }
            
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * (speed * Time.deltaTime));
            }
            
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * (speed * Time.deltaTime));
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * (speed * Time.deltaTime));
            }
        }
    }
}
