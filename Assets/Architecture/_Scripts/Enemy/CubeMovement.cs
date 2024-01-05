using UnityEngine;

namespace Test.Assets.Architecture._Scripts.Enemy
{
    public class CubeMovement
    {
        private Rigidbody2D _rigidbody;
        private GameObject _cubeObject;

        private float _speedMovement;

        public CubeMovement(Rigidbody2D rigidbody, float speedMovment, GameObject cube) 
        {
            _speedMovement = speedMovment;
            _cubeObject = cube;
            _rigidbody = rigidbody;
        }

        public void Movement() => 
            _rigidbody.AddForce(_cubeObject.transform.up * _speedMovement, ForceMode2D.Impulse);
       

        public void ConstantRotate() =>
            _cubeObject.transform.rotation *= Quaternion.AngleAxis(1, new Vector3(0, 0, 1));

        public void SetStartAngle(float minAngle, float maxAngle)
        {
            var angleZ = Random.Range(minAngle, maxAngle);
            _cubeObject.transform.rotation = Quaternion.Euler(0, 0, angleZ);

            Movement();
        }
    }
}
