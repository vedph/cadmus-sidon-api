using System.Reflection;
using Cadmus.Core;
using Cadmus.Core.Config;
using Cadmus.Core.Storage;
using Cadmus.General.Parts;
using Cadmus.Mongo;
using Cadmus.Philology.Parts;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace CadmusSidonApi.Services
{
    /// <summary>
    /// Application's repository provider.
    /// </summary>
    public sealed class AppRepositoryProvider : IRepositoryProvider
    {
        private readonly IConfiguration _configuration;
        private readonly IPartTypeProvider _partTypeProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRepositoryProvider"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <exception cref="ArgumentNullException">configuration</exception>
        public AppRepositoryProvider(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));

            var map = new TagAttributeToTypeMap();
            map.Add(new[]
            {
                // Cadmus.General.Parts
                typeof(NotePart).GetTypeInfo().Assembly,
                // Cadmus.Philology.Parts
                typeof(ApparatusLayerFragment).GetTypeInfo().Assembly
            });

            _partTypeProvider = new StandardPartTypeProvider(map);
        }

        /// <summary>
        /// Gets the part type provider.
        /// </summary>
        /// <returns>part type provider</returns>
        public IPartTypeProvider GetPartTypeProvider()
        {
            return _partTypeProvider;
        }

        /// <summary>
        /// Creates a Cadmus repository.
        /// </summary>
        /// <returns>repository</returns>
        /// <exception cref="ArgumentNullException">null database</exception>
        public ICadmusRepository CreateRepository()
        {
            // create the repository (no need to use container here)
            MongoCadmusRepository repository =
                new MongoCadmusRepository(
                    _partTypeProvider,
                    new StandardItemSortKeyBuilder());

            repository.Configure(new MongoCadmusRepositoryOptions
            {
                ConnectionString = string.Format(
                    _configuration.GetConnectionString("Default"),
                    _configuration.GetValue<string>("DatabaseNames:Data"))
            });

            return repository;
        }
    }
}
