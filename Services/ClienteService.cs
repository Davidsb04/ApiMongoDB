using ApiMongoDB.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ApiMongoDB.Services
{
    public class ClienteService
    {
        private readonly IMongoCollection<ClienteModel> _clienteCollection;
        
        public ClienteService(IOptions<ClienteDatabaseSettings> clienteServices)
        {
            var mongoClient = new MongoClient(
                clienteServices.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                clienteServices.Value.DataBaseName);

            _clienteCollection = mongoDatabase.GetCollection<ClienteModel>(
                clienteServices.Value.ClienteCollectionName);
        }

        public async Task<List<ClienteModel>> GetAsync() => 
            await _clienteCollection.Find(c => true).ToListAsync();

        public async Task<ClienteModel?> GetAsync(string id) => 
            await _clienteCollection.Find(c => c.Id == id).FirstOrDefaultAsync();

        public async Task CreatAsync(ClienteModel cliente) =>
            await _clienteCollection.InsertOneAsync(cliente);

        public async Task UpdateAsync(string id, ClienteModel cliente) =>
            await _clienteCollection.ReplaceOneAsync(c => c.Id == id, cliente);

        public async Task DeleteAsync(string id) =>
            await _clienteCollection.DeleteOneAsync(c => c.Id == id);
    }
}
