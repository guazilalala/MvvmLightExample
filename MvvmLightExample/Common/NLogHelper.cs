using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightExample.Common
{
	public class NLogHelper : INLogHelper
	{
		private readonly Logger log = LogManager.GetLogger("");
		public void Error(string msg, Exception exp = null)
		{
			if (exp == null)
				log.Error(msg);
			else
				log.Error(exp,msg);
		}

		public void Debug(string msg, Exception exp = null)
		{
			if (exp == null)
				log.Debug("#" + msg);
			else
				log.Debug("#" + msg + "  " + exp.ToString());
		}

		public void Info(string msg, Exception exp = null)
		{
			if (exp == null)
				log.Info(msg);
			else
				log.Info(exp,msg);
		}

		public void Warn(string msg, Exception exp = null)
		{
			if (exp == null)
				log.Warn(msg);
			else
				log.Warn(exp,msg);
		}

		public void Trace(string msg, Exception exp = null)
		{
			if (exp == null)
				log.Trace(msg);
			else
				log.Trace(exp,msg);
		}

		public void Fatal(string msg, Exception exp = null)
		{
			if (exp == null)
				log.Fatal(msg);
			else
				log.Fatal(exp,msg);
		}

		public void Log(LogLevel level, string msg)
		{
			log.Log(level, msg);
		}

		public void Log(object level, string msg, Exception exp = null)
		{
			if (exp == null)
				log.Log((LogLevel)level, msg);
			else
				log.Log((LogLevel)level, exp);
		}
	}
}

