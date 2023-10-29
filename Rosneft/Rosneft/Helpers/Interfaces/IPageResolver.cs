using System.Windows.Controls;

namespace Rosneft.Helpers.Interfaces
{
    public interface IPageResolver
    {
        Page GetPageInstance(string alias);
    }
}