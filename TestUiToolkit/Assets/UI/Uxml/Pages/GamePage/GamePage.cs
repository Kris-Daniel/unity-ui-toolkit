using Code;
using UI.FrameWork;
using UI.Uxml.Components.SliderComponent;
using UnityEngine.UIElements;

namespace UI.Uxml.Pages.GamePage
{
	public class GamePage : AXmlController
	{
		private readonly SliderComponent m_sliderComponent;
		
		public GamePage(AXmlController parent, VisualElement xmlElement) : base(parent, xmlElement)
		{
			m_sliderComponent = new SliderComponent(this, XmlElement.Q("slider"));
			
			Children.Add(m_sliderComponent);

			TestGamePlay.OnChangeDistance += SetSliderValue;
		}

		private void SetSliderValue(float value)
		{
			m_sliderComponent.SetValue(value);
		}
	}
}