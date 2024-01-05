using System.Runtime.InteropServices;
using Test.Assets.Architecture._Scripts._Main;
using UnityEngine;

namespace Test.Assets.Architecture._Scripts.Player
{ 
    public class PlayerModel : MonoBehaviour
    {
        public bool IsRightMove { get; private set; }

        [SerializeField] private float _speedMovement;
        [SerializeField][Range(0, 180)] private float _startAngle;

        private PlayerMovement _playerMove;

        private void Start()
        {
            _playerMove = new PlayerMovement(this, _speedMovement, _startAngle);
        }

        private void Update()
        {
            if (!GameCenter.Instance.IsSartGame) return;

            transform.position = _playerMove.Movement();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeDirection();
            }
        }

        private void ChangeDirection()
        {
            IsRightMove = !IsRightMove;
        }
    }
}

