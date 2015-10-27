﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BingImages.Shared
{

	public class Thumbnail
	{
		public string MediaUrl { get; set; }
		public string ContentType { get; set; }
		public string Width { get; set; }
		public string Height { get; set; }
		public string FileSize { get; set; }
	}

	public class BingImage
	{
		public string ID { get; set; }
		public string Title { get; set; }
		public string MediaUrl { get; set; }
		public string SourceUrl { get; set; }
		public string DisplayUrl { get; set; }
		public string Width { get; set; }
		public string Height { get; set; }
		public string FileSize { get; set; }
		public string ContentType { get; set; }
		public Thumbnail Thumbnail { get; set; }
	}

	public class BingQueryResults
	{
		[JsonProperty("results")]
		public List<BingImage> Results { get; set; }
	}

	public class BingQuery
	{
		[JsonProperty("d")]
		public BingQueryResults Query { get; set; }
	}
}

