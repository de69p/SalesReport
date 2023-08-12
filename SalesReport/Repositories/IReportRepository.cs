namespace SalesReport.Repositories;

public interface IReportRepository
{
    Task<Dictionary<string, decimal>> GetSalesByCountry();
}
