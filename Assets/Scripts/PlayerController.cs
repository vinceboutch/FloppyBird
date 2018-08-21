using UnityEngine;
using System.Collections;
namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        private TranslateMover translateMover;
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
            if (Input.GetKeyDown(KeyCode.W))
            {
                translateMover.Move(Vector3.up);
            }
            if(Input.GetKeyDown(KeyCode.S))
            {
                translateMover.Move(Vector3.down);
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                translateMover.Move(Vector3.right);
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                translateMover.Move(Vector3.left);
            }
        }
    }
}

