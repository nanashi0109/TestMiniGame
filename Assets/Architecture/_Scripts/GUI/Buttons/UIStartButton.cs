
using Test.Assets.Architecture._Scripts._Main;

namespace Test.Assets.Architecture._Scripts.GUI.Buttons
{
    public class UIStartButton : UIBaseButton
    {
        protected override void OnClick()
        {
            base.OnClick();

            GameCenter.Instance.StartGame();
        }
    }
}
