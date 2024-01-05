using Test.Assets.Architecture._Scripts._Main;
using UnityEngine;

namespace Test.Assets.Architecture._Scripts.Enemy
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyModel : MonoBehaviour
    {
        public CubeMovement GetCubeMovement => _cubeMovement;

        [SerializeField] private float _speedMovement;
        [SerializeField] private float _timeDestory = 2;

        private CubeMovement _cubeMovement;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _cubeMovement = new CubeMovement(_rigidbody2D, _speedMovement, gameObject);

            Destroy(this, _timeDestory);
        }
        private void Update()
        {
            _cubeMovement.ConstantRotate();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player" && gameObject.tag == "Point")
            {
                GameCenter.Instance.GetScoreCounter.IncreaseScore();
                Destroy(gameObject);
            }
            else if(collision.gameObject.tag == "Player" && gameObject.tag == "Enemy")
            {
                GameCenter.Instance.EndGame();
                Destroy(collision.gameObject);
            }
        }
    }
}
