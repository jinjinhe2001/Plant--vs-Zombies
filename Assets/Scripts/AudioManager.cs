using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// 播放特效音乐
    /// </summary>
    public void PlayEFMusic(AudioClip clip)
    {
        //从对象池获取一个音效物体
        EFAudio efAudio = PoolManager.Instance.GetObj(GameManager.Instance.GameConf.EFAudio).GetComponent<EFAudio>();
        efAudio.Init(clip);
    }

}
