using Test.Assets.Architecture._Scripts.GUI;

namespace Test.Assets.Architecture._Scripts._Main
{
    public class ScoreCounter
    {
        public int Score { get; private set; }

        private readonly GuiLocator _guiLocator;

        public ScoreCounter(GuiLocator gui)
        {
            Score = 0;
            _guiLocator = gui;
        }

        public void IncreaseScore()
        {
            Score++;
            _guiLocator.UpdateScore();
        }
    }
}
