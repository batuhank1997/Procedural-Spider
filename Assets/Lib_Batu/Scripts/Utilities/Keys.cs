﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Keys : MonoBehaviour
{
	#region PrefKeys
	public static string PKEY_LEVEL = "Level";
	#endregion PrefKeys

	#region AnimationKeys
	public const string ANIM_RUN = "Run";
	public const string ANIM_IDLE = "Idle";
	public const string ANIM_MODE = "AnimMode";
	#endregion AnimationKeys

	#region LevelKeys
	public const string LEVEL = "Level";
	public const string LEVELS = "Levels";
	public static string LEVELS_PATH = Path.Combine("Levels", "Level");
	public const string MAIN_SCENE = "Main";
	#endregion LevelKeys

	#region TagKeys
	public const string TAG_UNTAGGED = "Untagged";
	public const string TAG_PLAYER = "Player";
	public const string TAG_FINISH = "Finish";
	public const string TAG_RESPAWN = "Respawn";
	public const string TAG_EDITOR_ONLY = "EditorOnly";
	public const string TAG_MAIN_CAMERA = "MainCamera";
	public const string TAG_GAME_CONTROLLER = "GameController";
	#endregion TagKeys

	#region LayerKeys
	public const string LAYER_DEFAULT = "Default";
	public const string LAYER_TRANSPARENT_FX = "TransparentFX";
	public const string LAYER_IGNORE_RAYCAST = "Ignore Raycast";
	public const string LAYER_WATER = "Water";
	public const string LAYER_UI = "UI";
	#endregion LayerKeys

	#region OTHER
	public const string EDITOR = "Editor";
	public const string DEFAULT = "Default";
	#endregion OTHER
}
