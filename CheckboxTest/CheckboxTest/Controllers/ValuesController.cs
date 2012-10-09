﻿using CheckboxTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CheckboxTest.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public HttpResponseMessage Post(CheckboxViewModel model)
		{
			if (!ModelState.IsValid)
				return new HttpResponseMessage(HttpStatusCode.BadRequest);
			return new HttpResponseMessage(HttpStatusCode.OK);
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}