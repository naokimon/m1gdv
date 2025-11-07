using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private string currentSong = "";
    private float volume = 1.0f;
    private bool isPlaying = true;

    void PlaySong(string songName)
    {
        currentSong = songName;
        isPlaying = true;
        Debug.Log("Playing song: " + currentSong);
    }

    public void StopSong()
    {
        if (isPlaying)
        {
            Debug.Log("Song stopped.");
        }

        else

        {
            Debug.Log("No song is currently playing.");
        }
        isPlaying = false;
        currentSong = "";
    }


    public void SetVolume(float newVolume)
    {
        volume = Mathf.Clamp01(newVolume);
        Debug.Log("Volume set to: " + volume);
    }

    public string GetCurrentSong()
    {
        Debug.Log("Current song: " + currentSong);
        return currentSong;
    }

    public bool IsPlaying()
    {
        Debug.Log("Is playing: " + isPlaying);
        return isPlaying;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("Minecraft OST - Sweden");
            GetCurrentSong();
            IsPlaying();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
            IsPlaying();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SetVolume(0.8f);
        }
    }

    void Start()
    {
        Debug.Log("MusicPlayer script gestart.");
    }
}

