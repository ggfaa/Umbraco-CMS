using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Umbraco.Core.Services
{
    public interface IIconService
    {
        /// <summary>
        /// Gets an IconModel containing the icon name and SvgString according to an icon name found at the global icons path
        /// </summary>
        /// <param name="iconName"></param>
        /// <returns></returns>
        IconModel GetIcon(string iconName);

        /// <summary>
        /// Gets a list of all svg icons found at at the global icons path.
        /// </summary>
        /// <returns></returns>
        IList<IconModel> GetAllIcons();
    }
}
