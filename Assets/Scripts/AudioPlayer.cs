using UnityEngine;

namespace NoodleEater
{
    public class AudioPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource collectStarAudio;

        public void PlayCollectStar()
        {
            if (collectStarAudio)
            {
                collectStarAudio.Play();
            }
        }
    }
}