﻿// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Configurators
{
	using System;

	[Serializable]
	public class ValidationResultImpl :
		ValidationResult
	{
		public ValidationResultImpl(ValidationResultDisposition disposition, string key, string value, string message)
		{
			Disposition = disposition;
			Key = key;
			Value = value;
			Message = message;
		}

		public ValidationResultImpl(ValidationResultDisposition disposition, string key, string message)
		{
			Disposition = disposition;
			Key = key;
			Message = message;
		}

		public ValidationResultImpl(ValidationResultDisposition disposition, string message)
		{
			Key = "";
			Disposition = disposition;
			Message = message;
		}

		public ValidationResultDisposition Disposition { get; private set; }
		public string Key { get; private set; }
		public string Value { get; set; }
		public string Message { get; private set; }

		public override string ToString()
		{
			return string.Format("[{0}] {1}", Disposition, string.IsNullOrEmpty(Key) ? Message : Key + " " + Message);
		}
	}
}