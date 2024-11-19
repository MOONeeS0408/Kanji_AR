using UnityEngine;
using Vuforia;

public class CustomObserverEventHandler : DefaultObserverEventHandler
{
    public ImageTargetHandler imageTargetHandler;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (imageTargetHandler != null)
        {
            imageTargetHandler.OnTrackingFound();
        }
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (imageTargetHandler != null)
        {
            imageTargetHandler.OnTrackingLost();
        }
    }
}
