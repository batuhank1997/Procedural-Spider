using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : Singleton<CanvasManager>
{
	private void Start()
	{
		GameManager.Instance.GameWin += OnGameWin;
		GameManager.Instance.GameFail += OnGameFail;
		GameManager.Instance.GameStart += OnGameStart;
	}

	void OnGameWin()
	{

	}
	void OnGameFail()
	{

	}

	void OnGameStart()
	{

	}
}
