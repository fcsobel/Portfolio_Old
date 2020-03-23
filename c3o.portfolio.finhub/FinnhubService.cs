//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThreeFourteen.Finnhub.Client;
using ThreeFourteen.Finnhub.Client.Model;

namespace c3o.portfolio.Finhub
{
    public class FinnhubService
    {
        public List<Dividend> GetDividends(string symbol) { return this.GetDividendsAsync(symbol).Result; }

        public async Task<List<Dividend>> GetDividendsAsync(string symbol)
        {
            var apiKey = Environment.GetEnvironmentVariable("FinnhubApiKey", EnvironmentVariableTarget.Process);
            var client = new FinnhubClient(apiKey);
            return await client.Stock.GetDividend(symbol, DateTime.Today.AddYears(-1), DateTime.Today).ConfigureAwait(false);
        }
    }

    //public class PortfolioContext : DbContext
    //{
    //    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
    //    {
    //    }

    //    public DbSet<Entry> Entries { get; set; }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        //modelBuilder.Entity<Entry>().ToTable("Entries");
    //    }
    //}

    //public class Entry
    //{
    //    public int ID { get; set; }
    //    public string LastName { get; set; }
    //    public string FirstMidName { get; set; }
    //    public DateTime EnrollmentDate { get; set; }
    //}
}
