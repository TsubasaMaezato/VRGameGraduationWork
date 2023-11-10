using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMapChange : MonoBehaviour
{
    // ライトマップファイルと法線ライトマップを格納する配列
    [SerializeField] Texture2D[] lightMap;
    // 法線ライトマップを格納する配列
    [SerializeField] Texture2D[] dir;
    // ライトプローブファイルを格納する配列
    [SerializeField] LightProbes[] lightProbe;
    // ReflectionProbeファイルを格納する配列
    [SerializeField] Cubemap[] reflectionProbe;
    // リフレクションプローブを格納する変数
    [SerializeField] ReflectionProbe probeComponent;
    // 明るい照明のライトマップデータ
    LightmapData[] brightDatas;
    // 暗い照明のライトマップデータ
    LightmapData[] darkDatas;
    // 現在のライトマップデータが暗い照明か判定するフラグ
    public bool swapLight = false;

    // ゲームスタート時の処理
    void Start()
    {
        // 現在のシーンのライトマップデータを変数 brightDatas に格納
        //（明るい照明のライトマップデータに格納）
        brightDatas = LightmapSettings.lightmaps;
        // ライトマップファイル lightMap の長さを取得
        //（暗い照明のライトマップデータ darkDatas に格納）
        darkDatas = new LightmapData[lightMap.Length];
        // 繰り返し処理：暗いライトマップデータ、法線ライトマップのファイル数分
        for (int i = 0; i < darkDatas.Length; i++)
        {
            // ライトマップデータ lightingData を作成
            LightmapData lightingData = new LightmapData();
            // 配列 light に格納したライトマップファイルをライトマップデータに格納
            lightingData.lightmapColor = lightMap[i];
            // 配列 dir に格納した法線ライトマップファイルをライトマップデータに格納
            lightingData.lightmapDir = dir[i];
            // ライトマップデータ lightingData に格納された
            // ライトマップファイルと法線ライトマップファイルを配列 lightingDatas に格納
            darkDatas[i] = lightingData;
        }
    }

    // ライトマップデータの切替処理
    public void SwapLightmapData()
    {
        if (!swapLight)
        {
            DarkLightmap();
            Invoke("BrightLightmap", 10);
        }
    }

    // 暗い照明のライトマップデータを現在のシーンに適用する処理
    void DarkLightmap()
    {
        RenderSettings.ambientIntensity = 0.5f;
        // 暗い照明のライトマップファイルを現在のライトマップ設定に適用
        LightmapSettings.lightmaps = darkDatas;
        // 暗い照明のライトプローブファイルを現在のライトマップ設定に適用
        LightmapSettings.lightProbes = lightProbe[1];
        // 暗い照明のリフレクションプローブファイルを現在のリフレクションプローブに適用
        probeComponent.customBakedTexture = reflectionProbe[1];
        swapLight = true;
    }

    // 明るい照明のライトマップ設定を現在のシーンに適用する処理
    void BrightLightmap()
    {
        RenderSettings.ambientIntensity = 1;
        // 明るい照明のライトマップファイルを現在のライトマップ設定に適用
        LightmapSettings.lightmaps = brightDatas;
        // 明るい照明のライトプローブファイルを現在のライトマップ設定に適用
        LightmapSettings.lightProbes = lightProbe[0];
        // 明るい照明のリフレクションプローブファイルを現在のリフレクションプローブに適用
        probeComponent.customBakedTexture = reflectionProbe[0];
        swapLight = false;
    }
}
