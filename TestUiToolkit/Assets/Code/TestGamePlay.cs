using System;
using System.Collections;
using UI;
using UnityEngine;

namespace Code
{
	public class TestGamePlay : MonoBehaviour
	{
		private UiController m_uiController;

		public static Action<float> OnChangeDistance { get; set; }

		private void Awake()
		{
			m_uiController = GetComponent<UiController>();
		}

		private void Start()
		{
			StartCoroutine(nameof(StartGame));
		}

		IEnumerator StartGame()
		{
			yield return new WaitForSeconds(5f);
			m_uiController.App.OnChangeGameState("game");

			float time = 0;

			while (time < 10f)
			{
				time += Time.deltaTime;
				OnChangeDistance?.Invoke(time / 10f);
				yield return null;
			}
			
			OnChangeDistance?.Invoke(1);
		}
	}
}