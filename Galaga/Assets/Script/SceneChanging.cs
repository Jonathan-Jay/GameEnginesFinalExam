using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanging : MonoBehaviour
{
    public static void ChangeScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
}
