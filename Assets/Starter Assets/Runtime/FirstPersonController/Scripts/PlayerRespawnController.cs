using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerRespawnController : MonoBehaviour
    {
        [SerializeField] float m_Threshold = 0.0f;

        Vector3 m_Origin;
        CharacterController m_CharacterController;

        private void Awake()
        {
            m_Origin = transform.position;
            m_CharacterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            if (m_CharacterController.transform.position.y < m_Threshold)
            {
                Respawn();
            }
        }

        public void OnRespawn(InputValue value)
        {
            Debug.Log("On Respawn");
            Respawn();
        }

        private void Respawn()
        {
            m_CharacterController.enabled = false;
            transform.position = m_Origin;
            m_CharacterController.enabled = true;
        }
    }
}