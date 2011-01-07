using System.Web.Mvc;
using System.Web;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.ComponentModel;
using System.Linq;
using LiberMvc.Models;

namespace LiberMvc
{
	

	#region Attributes
	public class AuthAttribute : AuthorizeAttribute
	{
		// the "new" must be used here because we are overriding
		// the Roles property on the underlying class
		//public new SiteRoles Roles;

		#region Repository
		IUsuarioRepository rep;
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
				Usuario.Logado.Roles = rep.PegarUsuarioLogado().TipoUsuario.Descricao;
			}
			var role = Usuario.Logado.Roles;
			return string.IsNullOrEmpty(Roles) || Roles.Contains(role) || role == "Admin";
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

	#region Lixo

	//public static class AccountValidation
	//{
	//  public static string ErrorCodeToString(MembershipCreateStatus createStatus)
	//  {
	//    // See http://go.microsoft.com/fwlink/?LinkID=177550 for
	//    // a full list of status codes.
	//    switch (createStatus)
	//    {
	//      case MembershipCreateStatus.DuplicateUserName:
	//        return "Username already exists. Please enter a different user name.";

	//      case MembershipCreateStatus.DuplicateEmail:
	//        return "A username for that e-mail address already exists. Please enter a different e-mail address.";

	//      case MembershipCreateStatus.InvalidPassword:
	//        return "The password provided is invalid. Please enter a valid password value.";

	//      case MembershipCreateStatus.InvalidEmail:
	//        return "The e-mail address provided is invalid. Please check the value and try again.";

	//      case MembershipCreateStatus.InvalidAnswer:
	//        return "The password retrieval answer provided is invalid. Please check the value and try again.";

	//      case MembershipCreateStatus.InvalidQuestion:
	//        return "The password retrieval question provided is invalid. Please check the value and try again.";

	//      case MembershipCreateStatus.InvalidUserName:
	//        return "The user name provided is invalid. Please check the value and try again.";

	//      case MembershipCreateStatus.ProviderError:
	//        return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

	//      case MembershipCreateStatus.UserRejected:
	//        return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

	//      default:
	//        return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
	//    }
	//  }
	//}
	//[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	//public sealed class ValidatePasswordLengthAttribute : ValidationAttribute
	//{
	//  private const string _defaultErrorMessage = "'{0}' must be at least {1} characters long.";
	//  private readonly int _minCharacters = Membership.Provider.MinRequiredPasswordLength;

	//  public ValidatePasswordLengthAttribute()
	//    : base(_defaultErrorMessage)
	//  {
	//  }

	//  public override string FormatErrorMessage(string name)
	//  {
	//    return String.Format(CultureInfo.CurrentUICulture, ErrorMessageString,
	//        name, _minCharacters);
	//  }

	//  public override bool IsValid(object value)
	//  {
	//    string valueAsString = value as string;
	//    return (valueAsString != null && valueAsString.Length >= _minCharacters);
	//  }
	//}
	#endregion
}