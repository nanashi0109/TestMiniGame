using UnityEngine.SceneManagement;

namespace Test.Assets.Architecture._Scripts._Main
{
    public enum IDScene { INIT_SCENE = 0, LEVEL_SCENE = 1}

    public static class ScenesLoader
    {
        public static void Load(IDScene id)
            => SceneManager.LoadScene((int)id);
    }
}
