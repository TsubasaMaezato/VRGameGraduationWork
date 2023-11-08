using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class LightWindow : MonoBehaviour
{
    // �G�f�B�^�̃��j���[�ɍ��ڂ�ǉ�
    [MenuItem("Export/Export LightProbe")]

    // ���C�g�v���[�u�t�@�C���̏o�͏���
    static void Export()
    {
        // �ϐ� scene ���쐬���Č��݊J���Ă���V�[�����i�[
        Scene scene = SceneManager.GetActiveScene();
        // �ϐ� path ���쐬���ăV�[�������܂ފK�w�����i�[
        string path = "Assets/" + Path.GetFileNameWithoutExtension(scene.name);
        // �ϐ� path �̏ꏊ�ɃV�[�����̃t�H���_���쐬
        Directory.CreateDirectory(path);
        // ���C�g�}�b�v�ݒ�̃��C�g�v���[�u�t�@�C���̃A�Z�b�g���쐬���ĕϐ� path �̏ꏊ�ɏo��
        AssetDatabase.CreateAsset(GameObject.Instantiate
            (LightmapSettings.lightProbes), path + "/Lightprobe.asset");
    }
}
