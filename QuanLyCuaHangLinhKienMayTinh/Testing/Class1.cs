using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Warehouse;
using NUnit.Framework;
namespace Testing
{
    [TestFixture]
    public class BllProductTest
    {
        [Test]
        public void GetListProduct1()
        {
            BllProduct bll = new BllProduct();
            Assert.IsNull(bll.GetListProducts());
        }

        [Test]
        public void GetListProduct2()
        {
            BllProduct bll = new BllProduct();
            Assert.IsNotNull(bll.GetListProducts());
            ;
        }
    }
}
