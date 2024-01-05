using System.Collections;
using Test.Assets.Architecture._Scripts._Main;
using UnityEngine;

namespace Test.Assets.Architecture._Scripts.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [Header("Spawn rate objects")]
        [SerializeField] private float _minSpawnRate;
        [SerializeField] private float _maxSpawnRate;

        [Space]

        [Header("Angles for spawn object")]
        [SerializeField] private float _minObjectAngle;
        [SerializeField] private float _maxObjectAngle;


        private Vector2 _spawnPosition;
        private GameObject _spawnObject;
        private GameObject _enemy;
        private GameObject _point;

        private void Start()
        {
            var resourceLocator = Bootstrap.Instance.GetResourceLocator;
            _enemy = resourceLocator.CubeEnemyPrefab;
            _point = resourceLocator.PointPrefab;
            _spawnPosition = transform.position;

            StartCoroutine(SpawningEnemy());
        }

        private IEnumerator SpawningEnemy()
        {
            if (!GameCenter.Instance.IsSartGame)
            {
                yield return new WaitForSeconds(1);
                StopAllCoroutines();
                StartCoroutine(SpawningEnemy());
            }

            yield return new WaitForSeconds(Random.Range(_minSpawnRate, _maxSpawnRate));

            _spawnObject = Instantiate(GetObjectForSpawn(), _spawnPosition, Quaternion.identity);
            _spawnObject.GetComponent<EnemyModel>().GetCubeMovement.SetStartAngle(_minObjectAngle, _maxObjectAngle);

            StartCoroutine(SpawningEnemy());
        }

        private GameObject GetObjectForSpawn()
        {
            var ratio = Random.Range(0, 100);
            GameObject spawnObject;

            if (ratio > 80)
                spawnObject = _point;
            else
                spawnObject = _enemy;

            return spawnObject;
        }
    }
}
