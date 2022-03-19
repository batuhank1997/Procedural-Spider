using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
	public LevelManager levelManager { get; private set; }

	[HideInInspector] public ScriptableObject[] managers;

	private bool IsGameFinish { get; set; }
	private bool IsGameStarted { get; set; }

	public Action GameInit { get; set; }
	public Action GameStart { get; set; }
	public Action FinishEnter { get; set; }
	public Action GameWin { get; set; }
	public Action GameFail { get; set; }

	private void Awake()
	{
		//LevelManager = (LevelManager)managers.Find(manager => manager.name.Contains("LevelManager"));
		levelManager = Array.Find(managers, manager => manager.name.Contains("LevelManager")) as LevelManager;

		levelManager.Initialize();

		GameStart += Initialize;
		GameWin += OnGameWin;
		GameFail += OnGameFail;

		FinishEnter += () => IsGameFinish = true;
	}

	public void Initialize()
	{
		IsGameStarted = true;
	}

	private void OnGameWin()
	{
		GameWin = null;
	}
	private void OnGameFail()
	{
		GameFail = null;
	}

#if UNITY_EDITOR
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
			RestartLevel();

		if (Input.GetKeyDown(KeyCode.N))
			NextLevel();

		if (Input.GetKeyDown(KeyCode.B))
			PreviousLevel();
	}
#endif

	public void NextLevel()
	{
		PrefManager.IncrementLevel();
		SceneManager.LoadScene(Keys.MAIN_SCENE);
	}
	public void PreviousLevel()
	{
		PrefManager.DecrementLevel();
		SceneManager.LoadScene(Keys.MAIN_SCENE);
	}

	public void RestartLevel() => SceneManager.LoadScene(Keys.MAIN_SCENE);

}
