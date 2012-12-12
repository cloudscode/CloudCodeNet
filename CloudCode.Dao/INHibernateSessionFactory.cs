using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;

namespace CloudCode.Dao
{
    interface INHibernateSessionFactory
    {
        NHibernate.ISessionFactory SessionFactory { set; get; }
    }
}
