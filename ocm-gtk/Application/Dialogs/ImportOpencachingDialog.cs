﻿//
//  Copyright 2016  andreas
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using System.Collections.Generic;
using ocmengine;
using Gtk;

namespace ocmgtk
{
	public partial class ImportOpencachingDialog : Gtk.Dialog
	{
		private OCMMainWindow m_Win;

		public ImportOpencachingDialog ()
		{
			//this.Build ();
		}

		public ImportOpencachingDialog (OCMMainWindow win)
		{
			//this.Build ();
			m_Win = win;
		}
	}
}

