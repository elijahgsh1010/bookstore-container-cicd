using Microsoft.AspNetCore.Builder;
using AbpSolution1;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AbpSolution1WebTestModule>();

public partial class Program
{
}
