using UnityEngine;

namespace Test.Assets.Architecture._Scripts._Main
{
    public class ResourceLocator
    {
        public GameObject CubeEnemyPrefab { get; private set; }
        public GameObject PointPrefab { get; private set; }

        public void LoadResources()
        {
            CubeEnemyPrefab = (GameObject)Resources.Load("Prefabs/Units/CubeEnemy_prefab");
            PointPrefab = (GameObject)Resources.Load("Prefabs/Units/Point_prefab");
        }
    }
}
