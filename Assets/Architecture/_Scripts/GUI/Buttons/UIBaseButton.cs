using Test.Assets.Architecture._Scripts._Main;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
    public abstract class UIBaseButton : MonoBehaviour
    {
        private Button _button;
        protected virtual void Awake()
        {
            _button = GetComponent<Button>();
        }
        protected virtual void OnDisable()
        {
            _button.onClick.RemoveAllListeners();
        }
        protected virtual void OnEnable()
        {
            _button.onClick.AddListener(OnClick);    
        }
        protected virtual void OnClick()
        {
            var bootstarp = Bootstrap.Instance;
        }
    }
}
