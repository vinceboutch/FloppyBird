using UnityEngine;
using System.Collections;
namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        private TranslateMover translateMover;
        [SerializeField] private KeyCode upKey = KeyCode.W;
        [SerializeField] private KeyCode downKey = KeyCode.S;
        [SerializeField] private KeyCode rightKey = KeyCode.D;
        [SerializeField] private KeyCode leftKey = KeyCode.A;

        void Awake()
        {
            translateMover = GetComponent<TranslateMover>();
        }
        // Use this for initialization
        void Start()
        {
            var position = transform.position;
            Debug.Log("Ma position initiale est : " + position);
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(upKey))
            {
                translateMover.Move(Vector3.up);
            }
            if(Input.GetKeyDown(downKey))
            {
                translateMover.Move(Vector3.down);
            }
            if(Input.GetKeyDown(rightKey))
            {
                translateMover.Move(Vector3.right);
            }
            if(Input.GetKeyDown(leftKey))
            {
                translateMover.Move(Vector3.left);
            }
        }
    }
}

