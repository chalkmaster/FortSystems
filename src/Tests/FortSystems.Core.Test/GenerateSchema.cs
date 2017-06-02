using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace FortSystems.Core.Test
{
    [TestClass]
    public class TestBase
    {
        [TestMethod]
        public void CanGenerateSchema()
        {
            var cfg = new Configuration();
            cfg.Configure();

            new SchemaExport(cfg)
                .SetOutputFile("d:\\Fort_MyDDL.sql").Execute(true, true, false);
        }
    }
}
