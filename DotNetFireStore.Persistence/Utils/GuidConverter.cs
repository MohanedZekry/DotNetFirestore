using Google.Cloud.Firestore;

namespace DotNetFireStore.Persistence.Utils;

public class GuidConverter : IFirestoreConverter<Guid>
{
    public Guid FromFirestore(object value)
    {
        if (value is string guidString)
        {
            return Guid.Parse(guidString);
        }
        throw new InvalidOperationException("Invalid value for Guid conversion.");
    }

    public object ToFirestore(Guid value)
    {
        return value.ToString();
    }
}