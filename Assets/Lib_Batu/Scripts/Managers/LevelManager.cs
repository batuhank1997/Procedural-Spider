using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Scriptables/Managers/LevelManager", fileName = "LevelManager")]

public class LevelManager : ScriptableObject
{
	public Level activeLevel;
	public GameObject level;
	private int totalLevelCount = 0;

	private void SetLevel()
	{
		totalLevelCount = GetTotalLevelCount();
		activeLevel = GetLevel();

		InitializeLevel();
	}

	private void InitializeLevel()
	{
		// TODO : Set active level properties
		if (activeLevel != null && activeLevel.LevelPrefab != null)
			level = Instantiate(activeLevel.LevelPrefab);
	}

	private Level GetLevel()
	{
		int levelIndex = PrefManager.GetLevel;

		Level level = Resources.Load(Keys.LEVELS_PATH + levelIndex) as Level;

		if (level == null)
		{
			levelIndex = ((PrefManager.GetLevel - 1) % totalLevelCount) + 1;
			level = Resources.Load(Keys.LEVELS_PATH + levelIndex) as Level;
		}
		return level;
	}

	private int GetTotalLevelCount() => Resources.LoadAll<Level>(Keys.LEVELS).Length;

	public void Initialize()
	{
		SetLevel();
	}
	/*public void NextLevel()
	{
		PlayerPrefs.SetInt(Keys.LEVEL, PlayerPrefs.GetInt(Keys.LEVEL) + 1);

		InitializeLevel(PlayerPrefs.GetInt(Keys.LEVEL));

		SceneManager.LoadScene(Keys.MAIN_SCENE);
	}

	public void PreviousLevel()
	{
		PlayerPrefs.SetInt(Keys.LEVEL, PlayerPrefs.GetInt(Keys.LEVEL) - 1);

		InitializeLevel(PlayerPrefs.GetInt(Keys.LEVEL));

		SceneManager.LoadScene(Keys.MAIN_SCENE);
	}

	public void RestartLevel()
	{
		InitializeLevel(PlayerPrefs.GetInt(Keys.LEVEL));

		SceneManager.LoadScene(Keys.MAIN_SCENE);
	}*/


}
