using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PrefManager
{
	private static readonly string PKEY_MUSIC = "Music";

	public static int GetLevel => PlayerPrefs.GetInt(Keys.PKEY_LEVEL, 1);
	public static void SetLevel(int value) => PlayerPrefs.SetInt(Keys.PKEY_LEVEL, value);

	public static void ResetLevel() => SetLevel(1);


	public static void IncrementLevel()
	{
		int level = GetLevel;
		SetLevel(level + 1);
	}
	public static void DecrementLevel()
	{
		int level = GetLevel;
		SetLevel(level - 1);
	}
}
