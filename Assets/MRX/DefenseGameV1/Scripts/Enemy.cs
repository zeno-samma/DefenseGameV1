using System.Numerics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace MRX.DefenseGameV1
{
    public class Enemy : MonoBehaviour, IsComponentChecking
    {
        public float speed;//Private sẽ không chạy
        public float atkDistance;//Private sẽ không chạy
        private Animator m_anim;
        private Rigidbody2D m_rb;
        private Player m_player;
        private bool m_isDead;

        private GameController m_gc;
        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_rb = GetComponent<Rigidbody2D>();
            m_player = FindAnyObjectByType<Player>();//Hoặc FindFirstObjectByType: FindAnyObjectByType nhanh hơn nếu không quan tâm đến thứ tự
            m_gc = FindAnyObjectByType<GameController>();
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }
        public bool IsComponentNull()
        {
            return m_anim == null || m_rb == null || m_player == null;
        }
        // Update is called once per frame
        void Update()
        {
            if (IsComponentNull()) return;
            if (UnityEngine.Vector2.Distance(m_player.transform.position, transform.position) <= atkDistance)
            {
                m_anim.SetBool(Const.ATTACK_ANIM, true);
                m_rb.linearVelocity = UnityEngine.Vector2.zero;
            }
            else
            {
                m_rb.linearVelocity = new UnityEngine.Vector2(-speed, m_rb.linearVelocityY);
            }
        }
        public void Die()
        {
            if (IsComponentNull() || m_isDead) return;
            m_isDead = true;
            m_anim.SetBool(Const.DEATH_ANIM, true);
            gameObject.layer = LayerMask.NameToLayer(Const.DEATH_LAYER);
            Destroy(gameObject, 1f);
            if (m_gc)
                m_gc.Score++;
        }
    }

}