using System.Reflection;

namespace Cms.Api.UseCases
{
    internal static class Assemblies
    {
        public static readonly Assembly Applications = typeof(Extensions).Assembly;
    }

}
