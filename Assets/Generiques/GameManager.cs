using UnityEngine;

namespace Generiques
{
    public class GameManager : Singleton<GameManager>
    {
        public int Score = 10;

        private void Start()
        {
            Debug.Log("Score: " + Instance.Score);
        }
    }
}