using UnityEngine;

namespace Test.Assets.Architecture._Scripts._Main
{
    public class Bootstrap : MonoBehaviour
    {
        public static Bootstrap Instance { get; private set; }
        public ResourceLocator GetResourceLocator => _resourceLocator;

        private ResourceLocator _resourceLocator;

        private void Start()
        {
            if (!NeedBootsraping()) return;

            Construct();

            InitComponentSystems();

            LoadScene();
        }

        private void Construct()
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        private bool NeedBootsraping()
        {
            if (Instance == null)
                return true;
            else
                return false;
        }

        private void InitComponentSystems()
        {
            _resourceLocator = new ResourceLocator();
            _resourceLocator.LoadResources();
        }

        private void LoadScene()
            => ScenesLoader.Load(IDScene.LEVEL_SCENE);
    }
}

