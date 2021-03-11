using UI.FrameWork;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI.Uxml.Components.SliderComponent
{
	public class SliderComponent : AXmlController
	{
		private readonly VisualElement m_sliderFill;
		private Length m_leftLength;
		
		public SliderComponent(AXmlController parent, VisualElement xmlElement) : base(parent, xmlElement)
		{
			m_sliderFill = XmlElement.Q("", "slider_fill");
			m_leftLength = new Length(0, LengthUnit.Percent);
		}

		public void SetValue(float value)
		{
			value = Mathf.Clamp01(value) * 100f;
			
			m_leftLength.value = value;
			
			m_sliderFill.style.width = m_leftLength;
		}
	}
}