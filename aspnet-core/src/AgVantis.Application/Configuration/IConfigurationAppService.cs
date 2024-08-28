using System.Threading.Tasks;
using AgVantis.Configuration.Dto;

namespace AgVantis.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
