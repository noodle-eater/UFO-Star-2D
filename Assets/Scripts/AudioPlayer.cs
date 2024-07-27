using UnityEngine;

namespace NoodleEater
{
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource collectStarAudio;

        public void PlayCollectCoin()
        {
            if (collectStarAudio)
            {
                collectStarAudio.Play();
            }
        }
    }
}