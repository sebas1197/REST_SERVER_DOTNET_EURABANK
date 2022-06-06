using System;
using System.Reflection;

namespace Servidor_Rest_Eureka_Dotnet.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}