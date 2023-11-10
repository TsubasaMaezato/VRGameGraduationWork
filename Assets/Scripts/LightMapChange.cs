using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMapChange : MonoBehaviour
{
    // ���C�g�}�b�v�t�@�C���Ɩ@�����C�g�}�b�v���i�[����z��
    [SerializeField] Texture2D[] lightMap;
    // �@�����C�g�}�b�v���i�[����z��
    [SerializeField] Texture2D[] dir;
    // ���C�g�v���[�u�t�@�C�����i�[����z��
    [SerializeField] LightProbes[] lightProbe;
    // ReflectionProbe�t�@�C�����i�[����z��
    [SerializeField] Cubemap[] reflectionProbe;
    // ���t���N�V�����v���[�u���i�[����ϐ�
    [SerializeField] ReflectionProbe probeComponent;
    // ���邢�Ɩ��̃��C�g�}�b�v�f�[�^
    LightmapData[] brightDatas;
    // �Â��Ɩ��̃��C�g�}�b�v�f�[�^
    LightmapData[] darkDatas;
    // ���݂̃��C�g�}�b�v�f�[�^���Â��Ɩ������肷��t���O
    public bool swapLight = false;

    // �Q�[���X�^�[�g���̏���
    void Start()
    {
        // ���݂̃V�[���̃��C�g�}�b�v�f�[�^��ϐ� brightDatas �Ɋi�[
        //�i���邢�Ɩ��̃��C�g�}�b�v�f�[�^�Ɋi�[�j
        brightDatas = LightmapSettings.lightmaps;
        // ���C�g�}�b�v�t�@�C�� lightMap �̒������擾
        //�i�Â��Ɩ��̃��C�g�}�b�v�f�[�^ darkDatas �Ɋi�[�j
        darkDatas = new LightmapData[lightMap.Length];
        // �J��Ԃ������F�Â����C�g�}�b�v�f�[�^�A�@�����C�g�}�b�v�̃t�@�C������
        for (int i = 0; i < darkDatas.Length; i++)
        {
            // ���C�g�}�b�v�f�[�^ lightingData ���쐬
            LightmapData lightingData = new LightmapData();
            // �z�� light �Ɋi�[�������C�g�}�b�v�t�@�C�������C�g�}�b�v�f�[�^�Ɋi�[
            lightingData.lightmapColor = lightMap[i];
            // �z�� dir �Ɋi�[�����@�����C�g�}�b�v�t�@�C�������C�g�}�b�v�f�[�^�Ɋi�[
            lightingData.lightmapDir = dir[i];
            // ���C�g�}�b�v�f�[�^ lightingData �Ɋi�[���ꂽ
            // ���C�g�}�b�v�t�@�C���Ɩ@�����C�g�}�b�v�t�@�C����z�� lightingDatas �Ɋi�[
            darkDatas[i] = lightingData;
        }
    }

    // ���C�g�}�b�v�f�[�^�̐ؑ֏���
    public void SwapLightmapData()
    {
        if (!swapLight)
        {
            DarkLightmap();
            Invoke("BrightLightmap", 10);
        }
    }

    // �Â��Ɩ��̃��C�g�}�b�v�f�[�^�����݂̃V�[���ɓK�p���鏈��
    void DarkLightmap()
    {
        RenderSettings.ambientIntensity = 0.5f;
        // �Â��Ɩ��̃��C�g�}�b�v�t�@�C�������݂̃��C�g�}�b�v�ݒ�ɓK�p
        LightmapSettings.lightmaps = darkDatas;
        // �Â��Ɩ��̃��C�g�v���[�u�t�@�C�������݂̃��C�g�}�b�v�ݒ�ɓK�p
        LightmapSettings.lightProbes = lightProbe[1];
        // �Â��Ɩ��̃��t���N�V�����v���[�u�t�@�C�������݂̃��t���N�V�����v���[�u�ɓK�p
        probeComponent.customBakedTexture = reflectionProbe[1];
        swapLight = true;
    }

    // ���邢�Ɩ��̃��C�g�}�b�v�ݒ�����݂̃V�[���ɓK�p���鏈��
    void BrightLightmap()
    {
        RenderSettings.ambientIntensity = 1;
        // ���邢�Ɩ��̃��C�g�}�b�v�t�@�C�������݂̃��C�g�}�b�v�ݒ�ɓK�p
        LightmapSettings.lightmaps = brightDatas;
        // ���邢�Ɩ��̃��C�g�v���[�u�t�@�C�������݂̃��C�g�}�b�v�ݒ�ɓK�p
        LightmapSettings.lightProbes = lightProbe[0];
        // ���邢�Ɩ��̃��t���N�V�����v���[�u�t�@�C�������݂̃��t���N�V�����v���[�u�ɓK�p
        probeComponent.customBakedTexture = reflectionProbe[0];
        swapLight = false;
    }
}
