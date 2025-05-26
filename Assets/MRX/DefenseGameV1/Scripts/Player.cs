using System.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

namespace MRX.DefenseGameV1
{
    public class Player : MonoBehaviour, IsComponentChecking
    {
        private Animator m_anim;
        private float m_Attack_CD;
        private float m_Cur_Attack_CD;
        private bool m_Attacked;
        private bool isDead;
        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_Cur_Attack_CD = m_Attack_CD;
        }
        public bool IsComponentNull()
        {
            return m_anim == null;
        }
        private void OnEnable()
        {

        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {

            if (IsComponentNull()) return;
            if (Input.GetMouseButtonDown(0) && (!m_Attacked))
            {

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

        }
        private void OnDestroy()
        {

        }
        private void OnTriggerEnter2D(Collider2D colTarget)
        {
            if (IsComponentNull()) return;
            if (colTarget.CompareTag(Const.ENEMY_WEAPON_TAG) && !isDead)
            {
                m_anim.SetTrigger(Const.DEATH_ANIM);
                isDead = true;
            }
        }
    }

}