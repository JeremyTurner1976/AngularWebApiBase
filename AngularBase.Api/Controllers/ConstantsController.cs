using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularBase.Api.Abstract;
using AngularBase.Api.ViewModels;
using AngularBase.Data.AdventureWorks;

namespace AngularBase.Api.Controllers
{
	public class ConstantsController : BaseApiController
	{
		public IHttpActionResult GetApplicationConstants()
		{
			ApplicationConstants applicationConstants = new ApplicationConstants
			{
				ProductCategories = AdventureWorks.ProductCategories,
				ProductSubcategories = AdventureWorks.ProductSubcategories
			};

			return Ok(applicationConstants);
		}
	}
}
