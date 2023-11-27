using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;

public class GameBuilder : MonoBehaviour
{


    [MenuItem("Build/Build android")]
    public static void PerformAndroidBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/NetcodePlus/Demo/Scenes/Menu.unity", "Assets/NetcodePlus/Demo/Scenes/MenuLobby.unity", "Assets/NetcodePlus/Demo/Scenes/ServerGame.unity",
        "Assets/NetcodePlus/Demo/Scenes/ServerLobby.unity", "Assets/NetcodePlus/Demo/Scenes/DemoPuzzle.unity", "Assets/NetcodePlus/Demo/Scenes/DemoTank.unity", "Assets/NetcodePlus/Demo/Scenes/DemoSimple.unity"};
        buildPlayerOptions.locationPathName = "build/Android/Test.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
            
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if(summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + "bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build faild");
        }


    }

    [MenuItem("Build/Build Windows")]
    public static void PerformWondowsBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/NetcodePlus/Demo/Scenes/Menu.unity", "Assets/NetcodePlus/Demo/Scenes/MenuLobby.unity", "Assets/NetcodePlus/Demo/Scenes/ServerGame.unity",
        "Assets/NetcodePlus/Demo/Scenes/ServerLobby.unity", "Assets/NetcodePlus/Demo/Scenes/DemoPuzzle.unity", "Assets/NetcodePlus/Demo/Scenes/DemoTank.unity", "Assets/NetcodePlus/Demo/Scenes/DemoSimple.unity"};
        buildPlayerOptions.locationPathName = "build/Windows/Test.exe";
        buildPlayerOptions.target = BuildTarget.StandaloneWindows;
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + "bytes");
        }

        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build faild");
        }


    }

}
