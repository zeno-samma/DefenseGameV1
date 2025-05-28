using System.Collections;
using UnityEngine;

namespace MRX.DefenseGameV1
{
    public class GameController : MonoBehaviour
    {
        public float spawnTime;
        public Enemy[] enemyPrefabs;
        private bool m_isGameover;

        private int m_score;

        public int Score { get => m_score; set => m_score = value; }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            StartCoroutine(SpawnEnemy());
        }

        // Update is called once per frame
        void Update()
        {

        }
        IEnumerator SpawnEnemy()
        {
            while (!m_isGameover)
            {
                if (enemyPrefabs != null && enemyPrefabs.Length > 0)
                {
                    int randIdx = Random.Range(0, enemyPrefabs.Length);//(0,3) 0 1 2
                    Enemy loclaEnemyPrefabs = enemyPrefabs[randIdx];
                    if (loclaEnemyPrefabs)
                    {
                        Instantiate(loclaEnemyPrefabs, new Vector3(8, 0, 0), Quaternion.identity);
                    }
                }
                yield return new WaitForSeconds(spawnTime);
            }

        }
    }

}