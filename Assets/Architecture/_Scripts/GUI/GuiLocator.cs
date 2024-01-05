using Test.Assets.Architecture._Scripts._Main;
using UnityEngine;
using UnityEngine.UI;

namespace Test.Assets.Architecture._Scripts.GUI
{
    public class GuiLocator : MonoBehaviour
    {
        [SerializeField] private GameObject _startPanel;
        [SerializeField] private Text _score_txt;
        
        private ScoreCounter _scoreCounter;

        public void Construct(ScoreCounter scoreCounter)
        {
            _scoreCounter = scoreCounter;
        }

        public void DisactiveStartPanel()
        {
            _startPanel.SetActive(false);
        }
        public void UpdateScore()
        {
            _score_txt.text = _scoreCounter.Score.ToString();
        }
    }
}
