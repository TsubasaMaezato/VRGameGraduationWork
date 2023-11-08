using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class LightWindow : MonoBehaviour
{
    // エディタのメニューに項目を追加
    [MenuItem("Export/Export LightProbe")]

    // ライトプローブファイルの出力処理
    static void Export()
    {
        // 変数 scene を作成して現在開いているシーンを格納
        Scene scene = SceneManager.GetActiveScene();
        // 変数 path を作成してシーン名を含む階層情報を格納
        string path = "Assets/" + Path.GetFileNameWithoutExtension(scene.name);
        // 変数 path の場所にシーン名のフォルダを作成
        Directory.CreateDirectory(path);
        // ライトマップ設定のライトプローブファイルのアセットを作成して変数 path の場所に出力
        AssetDatabase.CreateAsset(GameObject.Instantiate
            (LightmapSettings.lightProbes), path + "/Lightprobe.asset");
    }
}
