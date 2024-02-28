using ScriptPortal.Vegas;

namespace LiveLineLogoRemover;

public static class LiveLineVideoMaker
{
    public static void RemoveLogo(VegasVideo vegasVideo)
    {
        vegasVideo.MainVideoEvent.SetLiveLinePanCropFrame();

        vegasVideo.MainVideoEvent.AddMedianEffect();
    }

    private static Effect AddMedianEffect(this VideoEvent track)
    {
        string plugInName = "VEGAS Median";
        string plugInParameter_HorizontalRange = "HorizontalRange";
        string plugInParameter_VerticalRange = "VerticalRange";
        string plugInParameter_Offset = "Offset";

        PlugInNode plugin = EntryPoint.Vegas.VideoFX.GetChildByName(plugInName);

        Effect effect = new(plugin);

        track.Effects.Add(effect);
        effect.ApplyBeforePanCrop = true;

        OFXDoubleParameter GetOFXParameter(string parameterName)
        {
            return (OFXDoubleParameter)effect.OFXEffect.FindParameterByName(parameterName);
        }

        OFXDoubleParameter horizontalRange = GetOFXParameter(plugInParameter_HorizontalRange);
        OFXDoubleParameter verticalRange = GetOFXParameter(plugInParameter_VerticalRange);
        OFXDoubleParameter offSet = GetOFXParameter(plugInParameter_Offset);

        horizontalRange.Value = 0.300;
        verticalRange.Value = 0.300;
        offSet.Value = 0.300;

        effect.ApplyBeforePanCrop = true;

        return effect;
    }

    private static void SetLiveLinePanCropFrame(this VideoEvent videoEvent)
    {
        float projectWidth = videoEvent.Project.Video.Width;
        float projectHeight = videoEvent.Project.Video.Height;
        VideoMotionVertex panCropScale = new(0.09796875f, 0.0701851851851852f); // projectSize * scale = rectangleSize
        VideoMotionVertex panCropMoveBy = new((projectWidth - (projectWidth * panCropScale.X)) / 2, (projectHeight - (projectHeight * panCropScale.Y)) / 2);

        VideoMotionKeyframe keyFrame = new(Timecode.FromSeconds(0));
        videoEvent.VideoMotion.Keyframes.Add(keyFrame);
        videoEvent.VideoMotion.ScaleToFill = false;

        keyFrame.ScaleBy(panCropScale);
        keyFrame.MoveBy(panCropMoveBy);
    }
}
