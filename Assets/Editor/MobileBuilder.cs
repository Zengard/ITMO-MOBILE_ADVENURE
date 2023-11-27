using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;

public class MobileBuilder : MonoBehaviour
{
    [MenuItem("Build/Build android mobile test")]
    public static void PerformMobileBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/NetcodePlus/Demo/Scenes/Menu.unity", "Assets/NetcodePlus/Demo/Scenes/MenuLobby.unity", "Assets/NetcodePlus/Demo/Scenes/ServerGame.unity",
        "Assets/NetcodePlus/Demo/Scenes/ServerLobby.unity", "Assets/NetcodePlus/Demo/Scenes/DemoPuzzle.unity", "Assets/NetcodePlus/Demo/Scenes/DemoTank.unity", "Assets/NetcodePlus/Demo/Scenes/DemoSimple.unity"};
        buildPlayerOptions.locationPathName = "build/Android/Test.apk";
        buildPlayerOptions.target = BuildTarget.Android;
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
