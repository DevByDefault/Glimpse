﻿using System.Collections.Generic;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Framework;
using System.Web;

namespace Glimpse.AspNet
{
    public class AspNetServiceLocator : IServiceLocator
    {
        private ILogger logger;

        internal ILogger Logger
        {
            get { return logger ?? (logger = new NullLogger()); }
            set { logger = value; }
        }

        public T GetInstance<T>() where T : class
        {
            var type = typeof(T);
            if (type == typeof(IFrameworkProvider))
            {
                return new AspNetFrameworkProvider(new HttpContextWrapper(HttpContext.Current), Logger) as T; // TODO: Fix this hack!
            }

            if (type == typeof(ResourceEndpointConfiguration))
            {
                return new HttpHandlerEndpointConfiguration() as T;
            }

            return null;
        }

        public ICollection<T> GetAllInstances<T>() where T : class
        {
            return null;
        }
    }
}