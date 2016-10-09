using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using AngularBase.Data.AdventureWorks;

namespace AngularBase.Api.Abstract
{
	public class BaseApiController : ApiController
	{
		protected AdventureWorks AdventureWorks { get; set; } = new AdventureWorks();
	}
}