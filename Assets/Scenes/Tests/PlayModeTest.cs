using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class PlayModeTest
    {

        [UnityTest]
        public IEnumerator SceneLoading(){
            //store test scene
            Scene currentScene = SceneManager.GetActiveScene();
            //load scene
            yield return SceneManager.LoadSceneAsync("testScene",LoadSceneMode.Additive);
            //After it is loaded,set the secne as Active
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("testScene"));
            //Assert that the game scene has been set to active.
            Assert.IsTrue(SceneManager.GetActiveScene().name == "testScene");
            //Clean up
            SceneManager.SetActiveScene(currentScene);

            yield return SceneManager.UnloadSceneAsync("testScene");
        }
    }
}
