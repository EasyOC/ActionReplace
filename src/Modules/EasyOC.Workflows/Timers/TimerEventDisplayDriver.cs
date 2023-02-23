using OrchardCore.Workflows.Display;

namespace EasyOC.Workflows.Timers
{
    public class TimerEventDisplayDriver : ActivityDisplayDriver<TimerEvent, TimerEventViewModel>
    {
        protected override void EditActivity(TimerEvent source, TimerEventViewModel model)
        {
            model.CronExpression = source.CronExpression;
            model.UseSiteTimeZone = source.UseSiteTimeZone;

        }

        protected override void UpdateActivity(TimerEventViewModel model, TimerEvent target)
        {
            target.CronExpression = model.CronExpression.Trim();
            target.UseSiteTimeZone = model.UseSiteTimeZone;
        }
    }
}
