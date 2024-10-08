﻿using UnityEngine;
using Random = UnityEngine.Random;

namespace NoodleEater
{
    public class Star : MonoBehaviour
    {
        [SerializeField] private int score = 10;
        [SerializeField] private Vector2 upperBound;
        [SerializeField] private Vector2 lowerBound;

        public int GetScore()
        {
            return score;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            MoveToRandomPosition();
        }

        private void MoveToRandomPosition()
        {
            transform.position = new Vector3(GetRandomXPosition(), GetRandomYPosition(), 0);
        }

        private float GetRandomXPosition()
        {
            return Random.Range(lowerBound.x, upperBound.x);
        }

        private float GetRandomYPosition()
        {
            return Random.Range(lowerBound.y, upperBound.y);
        }
    }
}