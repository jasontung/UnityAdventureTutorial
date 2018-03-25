using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// This script exists in the Persistent scene and manages the content
// based scene's loading.  It works on a principle that the
// Persistent scene will be loaded first, then it loads the scenes that
// contain the player and other visual elements when they are needed.
// At the same time it will unload the scenes that are not needed when
// the player leaves them.
public class SceneController : MonoBehaviour
{
    // This is the main external point of contact and influence from the rest of the project.
    // This will be called by a SceneReaction when the player wants to switch scenes.
    public void FadeAndLoadScene (SceneReaction sceneReaction)
    {
       
    }

}
