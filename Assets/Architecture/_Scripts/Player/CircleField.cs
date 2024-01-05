using UnityEngine;

namespace Test.Assets.Architecture._Scripts.Player
{
    public class CircleField : MonoBehaviour
    {
        public Vector2 GetCircleCenter => _circleCenter;
        public float GetCircleRadius => _circleRadius;

        [SerializeField] private float _circleRadius;
        [SerializeField] private Vector2 _circleCenter;

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(_circleCenter, _circleRadius);
        }
    }
}
