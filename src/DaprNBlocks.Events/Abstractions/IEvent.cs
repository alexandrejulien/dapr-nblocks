namespace DaprNBlocks.Events.Abstractions
{
    public interface IEvent
    {
        Guid Id { get; }
        string Name { get; }
        DateTime CreatedDate { get; }
        DateTime PublishedDate { get; set; }
    }
}