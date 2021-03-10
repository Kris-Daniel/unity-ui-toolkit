using System.Collections;
using UI.Uxml;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
	public class UiController : MonoBehaviour
	{
		private UIDocument m_uiDocument;
		public App App { get; private set; }

		private void Awake()
		{
			m_uiDocument = GetComponent<UIDocument>();
			App = new App(null, m_uiDocument.rootVisualElement.Q("app"));
			App.Render();
			StartCoroutine(nameof(StartGame));
		}

		IEnumerator StartGame()
		{
			yield return new WaitForSeconds(3f);
			App.OnChangeGameState("game");
		}
	}
}