#nullable enable

using ScriptPortal.Vegas;

namespace LiveLineLogoRemover;

public class VegasVideo
{
    public Vegas Vegas { get; private set; } = EntryPoint.Vegas;
    public Media Media { get; private set; }
    public VideoTrack MainVideoTrack { get; private set; } = null!;
    public AudioTrack MainAudioTrack { get; private set; } = null!;
    public VideoEvent? MainVideoEvent { get; private set; }
    public AudioEvent? MainAudioEvent { get; private set; }
    public TrackEventGroup ContainerGroup { get; private set; }

    public VegasVideo(string mediaPath, bool includeAudio)
    {
        Media = Media.CreateInstance(Vegas.Project, mediaPath);

        InitializeTracks(audio: includeAudio);

        MainVideoEvent = (MainVideoTrack?.AddMedia(Media) as VideoEvent) ?? null;
        MainAudioEvent = (MainAudioTrack?.AddMedia(Media) as AudioEvent) ?? null;

        ContainerGroup = this.GroupEvents(MainAudioEvent, MainVideoEvent);

        if (MainAudioEvent != null) MainAudioEvent.Length = MainVideoEvent?.Length;
    }

    private void InitializeTracks(bool audio = true, bool video = true)
    {
        if (video && MainVideoTrack is null)
        {
            MainVideoTrack = new VideoTrack();
            Vegas.Project.Tracks.Add(MainVideoTrack);
        }
        if (audio && MainAudioTrack is null)
        {
            MainAudioTrack = new AudioTrack();
            Vegas.Project.Tracks.Add(MainAudioTrack);
        }
    }

    private void ChangeGroupSpeed(double speed)
    {
        MainVideoEvent.ChangeEventSpeed(speed);
        if (MainAudioEvent != null) MainAudioEvent.Length = MainVideoEvent?.Length;
    }

    public void ApplyUserSetting()
    {
        if (EntryPoint.UserSettings.RelativeSpeed != 1.0)
            ChangeGroupSpeed(EntryPoint.UserSettings.RelativeSpeed);
    }
}
