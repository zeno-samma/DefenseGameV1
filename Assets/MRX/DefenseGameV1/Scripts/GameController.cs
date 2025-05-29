using System.Collections;
using MRX.DefenseGameV1.UI;
using UnityEngine;

namespace MRX.DefenseGameV1
{
    public class GameController : MonoBehaviour, IsComponentChecking
    {
        public float spawnTime;
        public Enemy[] enemyPrefabs;
        public GUIController guiGc;
        private bool m_isGameover;

        private int m_score;

        public int Score { get => m_score; set => m_score = value; }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // StartCoroutine(SpawnEnemy());
            if (IsComponentNull()) return;
            guiGc.ShowGameGUI(false);
            guiGc.UpdateMainCoin();
            guiGc.UpdateGamePlayerCoin();
        }
        public bool IsComponentNull()
        {
            return guiGc == null || enemyPrefabs == null || enemyPrefabs.Length == 0;
        }
        // Update is called once per frame
        void Update()
        {

            // guiGc.UpdateMainCoin();
            // guiGc.UpdateGamePlayerCoin();
        }
        public void PlayGame()
        {
            if (IsComponentNull()) return;
            guiGc.ShowGameGUI(true);
            m_isGameover = false;
            StartCoroutine(SpawnEnemy());
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