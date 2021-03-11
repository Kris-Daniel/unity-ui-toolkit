using UI.FrameWork;
using UnityEngine.UIElements;

namespace UI.Uxml.Pages.MenuPage
{
	public class MenuPage : AXmlController
	{
		public MenuPage(AXmlController parent, VisualElement xmlElement) : base(parent, xmlElement)
		{
			Button startButton = XmlElement.Q<Button>("btn-start");

			startButton.clicked += () =>
			{
				((App) parent).OnChangeGameState("game");
			};
		}
	}
}