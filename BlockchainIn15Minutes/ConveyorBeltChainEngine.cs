using BlockchainIn15Minutes.Interfaces;
using BlockchainIn15Minutes.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockchainIn15Minutes
{
    public class ConveyorBeltChainEngine : IChain
    {
        private IHasherService _hasherService;
        private IServiceProvider _servicesProvider;
        private ILogger _logger;
        private List<Block> _blocks;

        public ConveyorBeltChainEngine(IServiceCollection services)
        {
            _servicesProvider = services.BuildServiceProvider();
            _hasherService = _servicesProvider.GetService<IHasherService>();
            _blocks = new List<Block>();// TODO: DI
            _logger = _servicesProvider.GetRequiredService<ILoggerFactory>()
                .CreateLogger<ConveyorBeltChainEngine>();

            _logger.LogDebug("ConveyorBeltChainEngine created successfully.");
        }

        public void StartChain()
        {
            //create the list of transactions
            IList<Transaction> genesisTransactions = new List<Transaction>
            {
                new Transaction
                {
                    AddressFrom = "1BvBMSEYstWetqTFn5Au4m4GFg7xJaNVN2",
                    AddressTo = "3J98t1WpEZ73CNmQviecrnyiWrnqRhWNLy",
                    Amount = 10m, //send 10 bitcoins :)
                },
                new Transaction
                {
                    AddressFrom = "1ZvDMSEYstWetqTFn5Au4m4GFg7xJaNVIn2",
                    AddressTo = "3K89t1WpEZ73CNmQviecrnyiWrnqRhWWin",
                    Amount = 5m, //send 10 bitcoins :)
                },
            };

            var genesisBlock = new Block(0, genesisTransactions);

            var txByteArray = Encoding.UTF8.GetBytes(genesisBlock);

            // initialize the genesis block
            Block genesisBlock = new Block
            {
                PreviousBlockHash = 0 // no previous block
                // genesisTransactions
            };

            var sf = "This";

            var test = _hasherService.ComputeSha256(Encoding.UTF8.GetBytes(sf));
            var bastest = Convert.ToBase64String(test);
        }
    }
}