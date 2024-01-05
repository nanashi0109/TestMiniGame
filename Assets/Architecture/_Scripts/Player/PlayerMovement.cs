using Test.Assets.Architecture._Scripts._Main;
using UnityEngine;

namespace Test.Assets.Architecture._Scripts.Player
{
    public class PlayerMovement
    {
        private PlayerModel _model;

        private float _speedMovement;
        private float _angleMovemet;

        private Vector2 _center;
        private float _raduis;

        public PlayerMovement(PlayerModel model ,float speed, float startAngle)
        {
            _model = model;
            _speedMovement = speed;
            _angleMovemet = startAngle;

            _center = GameCenter.Instance.GetCircleField.GetCircleCenter;
            _raduis = GameCenter.Instance.GetCircleField.GetCircleRadius;
        }

        public Vector2 Movement()
        {
            RotateDirection();

            var x = Mathf.Cos(_angleMovemet * _speedMovement) * _raduis + _center.x;
            var y = Mathf.Sin(_angleMovemet * _speedMovement) * _raduis + _center.y;

            return new Vector2(x, y);
        }

        public void RotateDirection()
        {
            if (_model.IsRightMove)
            {
                _angleMovemet += Time.deltaTime;
            }
            else
            {
                _angleMovemet -= Time.deltaTime;
            }

        }
    }
}
