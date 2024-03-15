namespace SammysBBQ.Data
{
    public class MenuItemContent
    {
        public string ItemName { get; }
        public string? ItemImagePath { get; }
        public string? Description { get; }

        public MenuItemContent(string itemName, string? itemImagePath = null, string? description = null)
        {
            ItemName = itemName;
            ItemImagePath = itemImagePath;
            Description = description;
        }
    }
}