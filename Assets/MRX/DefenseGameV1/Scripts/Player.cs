using System.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

namespace MRX.DefenseGameV1
{
    public class Player : MonoBehaviour,IsComponentChecking
    {
        public Animator m_anim;
        public float m_Attack_CD;
        public float m_Cur_Attack_CD;
        public bool m_Attacked;
        private void Awake()
        {
            // Debug.Log("Awake");
            //Get component script
            // sp = GetComponent<SpriteRenderer>();
            // sp.color = Color.blue;
            m_anim = GetComponent<Animator>();
            m_Cur_Attack_CD = m_Attack_CD;
        }
        public bool IsComponentNull()
        {
            return m_anim == null;
        }
        private void OnEnable()
        {
            // Debug.Log("OnEnable");
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Debug.Log("Start");
            // myTransform.position = new Vector3(3, 3, 0);
            // if (EnemyPrefabs) //Check object # null
            // {
            //     // Create object
            //     var enemyClone = Instantiate(EnemyPrefabs, new Vector3(2, 2, 0f), Quaternion.identity);
            //     // Destroy object after 5s
            //     Destroy(enemyClone, 5f);
            // }
            // Get component inspector
            // if (sp)
            // {
            //     sp.color = Color.red;
            // }
            // StartCoroutine("DemoIE");
            // StartCoroutine(DemoIE());//Delay action hard
            // Invoke("Work", 1f);//Delay action basic
            //Save score in mycomputer
            // score = PlayerPrefs.GetFloat("Score", 0);
            // score += 10;
            // PlayerPrefs.SetFloat("Score", score);
            // Debug.Log("Điểm số : " + score);

        }

        // Update is called once per frame
        void Update()
        {
            // Debug.Log("Hello Update");
            // Debug.Log(gameObject.transform);
            if (IsComponentNull()) return;
            if (Input.GetMouseButtonDown(0) && (!m_Attacked))
            {
                // Debug.Log("Người chơi đã ấn chuột trái");
                m_anim.SetBool(Const.ATTACK_ANIM, true);
                m_Attacked = true;

            }
            if (m_Attacked)
            {
                Debug.Log("m_Attacked true");
                m_Cur_Attack_CD -= Time.deltaTime;
                if (m_Cur_Attack_CD <= 0)
                {
                    m_Attacked = false;
                    m_Cur_Attack_CD = m_Attack_CD;
                }
            }
        }
        public void RsAnim()
        {
            if (IsComponentNull()) return;
            m_anim.SetBool(Const.ATTACK_ANIM, false);
        }

        private void OnDisable()
        {
            // Debug.Log("OnDisable");
        }
        private void OnDestroy()
        {
            // Debug.Log("OnDestroy"); 
        }
        // //One hit 
        // private void OnCollisionEnter2D(Collision2D colTarget)
        // {
        //     // Debug.Log("Đối tượng va chạm là: " + colTarget.gameObject.tag);
        //     // colTarget.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        // }
        // //Frame by frame
        // private void OnCollisionStay2D(Collision2D colTarget)
        // {
        //     Debug.Log("Đối tượng va chạm là: " + colTarget.gameObject.tag);
        //     colTarget.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

        // }

        // private void OnTriggerEnter2D(Collider2D colTarget)
        // {
        //     Debug.Log("Đối tượng va chạm là: " + colTarget.gameObject.tag);
        //     colTarget.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        // }

    }

}