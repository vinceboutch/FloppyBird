using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainController : MonoBehaviour {

    public static class Scenes
    {
        public const string Main = "Main";
        public const string Game = "Game";
    }
    private static bool  IsSceneIsloaded(string name)
    {
        for (var i = 0; i < SceneManager.sceneCount; i++)
            if (SceneManager.GetSceneAt(i).name == name) return true;
        return false;
    }
	private static void LoadGame()
    {
        if (!IsSceneIsloaded(Scenes.Game))
        {
            SceneManager.LoadSceneAsync(Scenes.Game,LoadSceneMode.Additive);
        }

        SceneManager.SetActiveScene(SceneManager.GetSceneByName(Scenes.Game));

    }
    private void Start()
    {
        LoadGame();
    }

}
