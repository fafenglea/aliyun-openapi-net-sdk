/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class ProfileGetResponse : AcsResponse
	{

		private int? errorCode;

		private string errorMessage;

		private bool? success;

		private string requestId;

		private long? userId;

		private bool? autoInstall;

		private bool? enableInstallAgentNewECS;

		private string enableActiveAlert;

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}

		public bool? AutoInstall
		{
			get
			{
				return autoInstall;
			}
			set	
			{
				autoInstall = value;
			}
		}

		public bool? EnableInstallAgentNewECS
		{
			get
			{
				return enableInstallAgentNewECS;
			}
			set	
			{
				enableInstallAgentNewECS = value;
			}
		}

		public string EnableActiveAlert
		{
			get
			{
				return enableActiveAlert;
			}
			set	
			{
				enableActiveAlert = value;
			}
		}
	}
}