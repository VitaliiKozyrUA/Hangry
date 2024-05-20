using Hangry.administrator.login.data.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.administrator.login.data.datasources
{
    [TestClass]
    public class CredentialsDataSourceTests
    {
        private ICredentialsDataSource _credentialsDataSource;

        [TestInitialize]
        public void Setup()
        {
            _credentialsDataSource = new CredentialsLocalDataSource();
        }

        [TestMethod]
        public void GetCredentials_ReturnsValidCredentials()
        {
            Credentials credentials = _credentialsDataSource.GetCredentials();

            Assert.IsNotNull(credentials);
            Assert.AreEqual("1234", credentials.Password);
        }
    }
}
