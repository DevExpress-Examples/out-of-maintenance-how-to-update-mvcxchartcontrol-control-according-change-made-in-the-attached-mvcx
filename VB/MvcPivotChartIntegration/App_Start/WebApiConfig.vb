Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Namespace MvcApplication1
	Public NotInheritable Class WebApiConfig

		Private Sub New()
		End Sub

		Public Shared Sub Register(ByVal config As HttpConfiguration)
			config.Routes.MapHttpRoute(name:= "DefaultApi", routeTemplate:= "api/{controller}/{id}", defaults:= New With {Key .id = RouteParameter.Optional})

			' Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
			' To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
			' For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
			'config.EnableQuerySupport();
		End Sub
	End Class
End Namespace