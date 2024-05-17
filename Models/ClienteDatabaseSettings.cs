namespace ApiMongoDB.Models
{
    public class ClienteDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DataBaseName { get; set; } = null!;

        public string ClienteCollectionName { get; set; } = null!;
    }
}
