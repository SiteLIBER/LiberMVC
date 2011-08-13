using System.Web.Mvc;
using System.Web;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.ComponentModel;
using System.Linq;
using LiberMvc.Models;
using System.Collections.Generic;

namespace LiberMvc
{
	

	#region Attributes
	public class AuthAttribute : AuthorizeAttribute
	{
		// the "new" must be used here because we are overriding
		// the Roles property on the underlying class
		//public new SiteRoles Roles;

		#region Repository
		UsuarioRepository rep;
		#endregion

		#region AuthorizeCore
		protected override bool AuthorizeCore(HttpContextBase httpContext)
		{
			if (httpContext == null)
				throw new ArgumentNullException("httpContext");

			if (!httpContext.User.Identity.IsAuthenticated)
				return false;

			// caso sessão tenha expirado
			if (Usuario.Logado.Roles == null)
			{
				if (rep == null) rep = new UsuarioRepository();
				Usuario.Logado.Roles = rep.UsuarioLogado.Pessoa.Titulos.Select(t => t.Titulo.Codigo).ToList();
			}
			var myroles = Usuario.Logado.Roles;
			return string.IsNullOrEmpty(Roles) || !myroles.TrueForAll(r => !Roles.Split(',').Contains(r)) || myroles.Contains("Admin");
		}
		#endregion
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public sealed class PropertiesMustMatchAttribute : ValidationAttribute
	{
		private const string _defaultErrorMessage = "'{0}' e '{1}' não batem.";
		private readonly object _typeId = new object();

		public PropertiesMustMatchAttribute(string originalProperty, string confirmProperty)
			: base(_defaultErrorMessage)
		{
			OriginalProperty = originalProperty;
			ConfirmProperty = confirmProperty;
		}

		public string ConfirmProperty { get; private set; }
		public string OriginalProperty { get; private set; }

		public override object TypeId
		{
			get
			{
				return _typeId;
			}
		}

		public override string FormatErrorMessage(string name)
		{
			return String.Format(CultureInfo.CurrentUICulture, ErrorMessageString,
					OriginalProperty, ConfirmProperty);
		}

		public override bool IsValid(object value)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(value);
			object originalValue = properties.Find(OriginalProperty, true /* ignoreCase */).GetValue(value);
			object confirmValue = properties.Find(ConfirmProperty, true /* ignoreCase */).GetValue(value);
			return Object.Equals(originalValue, confirmValue);
		}
	}
	#endregion
}