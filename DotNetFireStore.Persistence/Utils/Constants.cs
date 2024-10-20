namespace DotNetFireStore.Persistence.Utils
{
    public enum CollectionNames
    {
        Users,
        Groups
    }
    public static class Constants
    {
        public static string GetCollectionName(CollectionNames collectionName)
        {
            return collectionName.ToString().ToLower();
        }
    }
}
