using ScriptPortal.Vegas;

namespace LiveLineLogoRemover;

public static class MediaManager
{
    public static TrackEvent AddMedia(this Track track, Media media)
    {
        Timecode start = EntryPoint.Vegas.Transport.CursorPosition;

        if (track.IsVideo())
        {
            VideoTrack videoTrack = track as VideoTrack;
            VideoStream take = media.GetVideoStreamByIndex(0);
            VideoEvent videoEvent = videoTrack.AddVideoEvent(start, take.Length);
            videoEvent.AddTake(take);
            return videoEvent;
        }
        else
        {
            AudioTrack audioTrack = track as AudioTrack;
            AudioStream take = media.GetAudioStreamByIndex(0);
            AudioEvent audioEvent = audioTrack.AddAudioEvent(start, take.Length);
            audioEvent.AddTake(take);
            return audioEvent;
        }
    }

    public static void AddFade(this TrackEvent @event, int seconds, params OwnerType[] types)
    {
        foreach (var type in types)
        {
            if (type != OwnerType.EventFadeOut && type != OwnerType.EventFadeIn)
            {
                throw new System.Exception("Tipo de Fade não encontrado");
            }

            if (type == OwnerType.EventFadeIn && @event.IsVideo())
            {
                Effect fadeInTx = new (EntryPoint.Vegas.Transitions.FindChildByName("VEGAS Dissolve"));
                @event.FadeIn.Transition = fadeInTx;
                fadeInTx.Preset = "Additive Dissolve";
                

                //@event.FadeIn.Curve = CurveType.Smooth;
                //@event.FadeIn.Length = Timecode.FromSeconds(seconds);
            }

            if (type == OwnerType.EventFadeOut && @event.IsVideo())
            {
                Effect fadeOutTx = new(EntryPoint.Vegas.Transitions.FindChildByName("VEGAS Slide"));
                @event.FadeOut.Transition = fadeOutTx;
                fadeOutTx.Preset = "Additive Dissolve";

                //@event.FadeOut.Curve = CurveType.Smooth;
                //@event.FadeOut.Length = Timecode.FromSeconds(seconds);
            }
        }
    }

    public static void ChangeEventLenght(this TrackEvent @event, double multiplicator)
    {
        Take take = @event.ActiveTake;

        Timecode startTime = @event.Start;
        Timecode endTime = @event.End;

        Timecode originalLength = endTime - startTime;

        double newLengthMilliseconds = originalLength.ToMilliseconds() / multiplicator;
        Timecode newLength = Timecode.FromMilliseconds(newLengthMilliseconds);

        @event.End = @event.Start + newLength;
    }

    public static void ChangeEventSpeed(this TrackEvent trackEvent, double speed)
    {
        trackEvent.ChangeEventLenght(speed);
        trackEvent.AdjustPlaybackRate(speed, false);
    }

    public static TrackEventGroup GroupEvents(this VegasVideo vegasVideo, params TrackEvent[] events)
    {
        TrackEventGroup tracks = new ();

        vegasVideo.Vegas.Project.Groups.Add(tracks);

        foreach (TrackEvent item in events)
        {
            if (item is not null)
                tracks.Add(item);
        }

        return tracks;
    }
}
