using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlay = false;
    private int audioClipIndex = 0;

    public AudioClip[] audioClips;
    public Button previousButton;
    public Button nextButton;
    public Button playOrPauseButton;
    public Text playOrPauseText;
    public Text MusicNameText;                  //歌曲名称
    public Text NowTimeText;                //歌曲当前时间(实际上获取的是AudioSource的时间)
    public Text FullTimeText;               //歌曲总时间
    public Slider MusicTimeSlider;               //控制快进或者后退的滑块

    public Sprite PausePicture;
    public Sprite PlayPicture;

    private int cliphour;
    private int clipminute;
    private int clipsecond;

    private int curhour;
    private int curminute;
    private int cursecond;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();

        audioSource.clip = audioClips[audioClipIndex];
        MusicNameText.text = audioClips[audioClipIndex].name;
/* 
        cliphour = (int) audioSource.clip.length / 3600;
        clipminute = (int) (audioSource.clip.length - cliphour * 3600)/ 60;
        clipsecond = (int) (audioSource.clip.length - cliphour * 3600 - clipminute * 60); 
        FullTimeText.text = string.Format("{0:D0}:{1:D0}:{2:D0}", cliphour, clipminute, clipsecond);
       
*/
        //添加监听事件，通常用于UI界面的按钮，单选框，滑动条等，点击按钮，单选框，拖动滑动条时，会发送消息给某个函数，函数做出相应的功能。
        previousButton.onClick.AddListener(PreviousAudio);     //按下previousButton按键，会给PreviousAudio函数发消息。
        nextButton.onClick.AddListener(NextAudio);
        playOrPauseButton.onClick.AddListener(PlayOrPauseAudio);

        MusicTimeSlider.onValueChanged.AddListener(
            delegate{
                        setAudioTimeValueChange();
            }
        );

    }

    private void Showlyrics()
    {
        
    }

    private void updateMusicInfo()              
    {
        MusicNameText.text = audioClips[audioClipIndex].name;

        cliphour = (int) audioSource.clip.length / 3600;
        clipminute = (int) (audioSource.clip.length - cliphour * 3600)/ 60;
        clipsecond = (int) (audioSource.clip.length - cliphour * 3600 - clipminute * 60); 
        FullTimeText.text = string.Format("{0:D02}:{1:D2}:{2:D2}", cliphour, clipminute, clipsecond);
    }

    private void setAudioTimeValueChange()      //改变滑块值；
    {
       //audioSource.time = MusicTimeSlider.value * audioSource.clip.length;
        audioSource.time = MusicTimeSlider.value * audioSource.clip.length;
    }

    private void PlayOrPauseAudio()
    {
        if (isPlay)
        {
            isPlay = false;
            audioSource.Pause();
            //playOrPauseText.text = "Play";
            playOrPauseButton.GetComponent<Image>().sprite = PausePicture;
        }
        else
        {
            isPlay = true;
            audioSource.Play();
            //playOrPauseText.text = "Pause";
            playOrPauseButton.GetComponent<Image>().sprite = PlayPicture;
        }
    }

    private void NextAudio()
    {
        audioClipIndex++;

        if (audioClipIndex > audioClips.Length - 1)
        {
            audioClipIndex = 0;
        }

        if (audioSource.isPlaying == true)
        {
            audioSource.Stop();
        }

        audioSource.clip = audioClips[audioClipIndex];

        updateMusicInfo();                  //更新歌曲信息
        ShowAudioTIme();

        audioSource.Play();
        playOrPauseButton.GetComponent<Image>().sprite = PlayPicture;
    }

    private void PreviousAudio()
    {
        audioClipIndex--;

        if (audioClipIndex < 0)
        {
            audioClipIndex = audioClips.Length - 1;
        }

        if (audioSource.isPlaying == true)
        {
            audioSource.Stop();
        }

        audioSource.clip = audioClips[audioClipIndex];

        updateMusicInfo();                  //更新歌曲信息
        ShowAudioTIme();

        audioSource.Play();
        playOrPauseButton.GetComponent<Image>().sprite = PlayPicture;
    }

    private void ShowAudioTIme()
    {
        curhour = (int)audioSource.time / 3600;
        curminute = (int)(audioSource.time - curhour * 3600) / 60;
        cursecond = (int)(audioSource.time - curhour * 3600 - curminute * 60);

        NowTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", curhour, curminute, cursecond);
        MusicTimeSlider.value = audioSource.time / audioSource.clip.length;
        //Debug.Log("进度条当前值:" + MusicTimeSlider.value);
    }
    
    void Update()               //每帧都更新时间
    {
        ShowAudioTIme();
        updateMusicInfo();
    }

}
