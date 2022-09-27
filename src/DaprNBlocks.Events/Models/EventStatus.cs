namespace DaprNBlocks.Events.Models
{
    public enum EventStatus
    {
        Processing = 0,
        Upcoming = 1,
        Ongoing = 2,
        Completed = 3,
        Archived = 4,
        Cancelled = 5
    }

    //Processing - The event is being created.
    //Upcoming - The event start date and time is in the future.
    //Ongoing - The event start date and time is in the past, and the event end date and time is in the future.
    //Completed - The event’s end date and time is in the past.
    //Archived - The event’s archive date is in the past.
    //Cancelled - A planner has clicked Cancel Event in Home > Actions.
}