using Test.Assets.Architecture._Scripts.GUI;
using Test.Assets.Architecture._Scripts.Player;
using UnityEngine;

namespace Test.Assets.Architecture._Scripts._Main
{
    public class GameCenter : MonoBehaviour
    {
        public static GameCenter Instance { get; private set; }
        public bool IsSartGame { get; private set; } = false;

        public ScoreCounter GetScoreCounter => _scoreCounter;
        public CircleField GetCircleField => _circleField;
        public GuiLocator GetGuiLocator => _guiLocator;
        
        [SerializeField] private CircleField _circleField;
        [SerializeField] private GuiLocator _guiLocator;
        private ScoreCounter _scoreCounter;



        private void Awake()
        {
            Instance = this;

            _scoreCounter = new ScoreCounter(_guiLocator);
            _guiLocator.Construct(_scoreCounter);
        }

        public void StartGame()
        {
            IsSartGame = true;
            _guiLocator.DisactiveStartPanel();
        }
        public void EndGame()
        {
            IsSartGame = false;
            ScenesLoader.Load(IDScene.LEVEL_SCENE);
        }
    }
}
