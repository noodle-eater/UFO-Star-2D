using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace NoodleEater
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private int score = 10;
        [SerializeField] private Vector2 upperBound;
        [SerializeField] private Vector2 lowerBound;
        
        public int Score => score;

        // private void OnTriggerEnter2D(Collider2D other)
        // {
        //     transform.position = new Vector3(GetRandomXPosition(), GetRandomYPosition(), 0);
        // }

        private void OnCollisionEnter2D(Collision2D other)
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