using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.Common
{
    public interface INLogHelper
    {
		void Trace(string msg, Exception exp = null);
		void Error(string msg, Exception exp = null);
		void Debug(string msg, Exception exp = null);
		void Info(string msg, Exception exp = null);
		void Warn(string msg, Exception exp = null);
		void Fatal(string msg, Exception exp = null);

		void Log(object level, string msg, Exception exp = null);
	}
}
