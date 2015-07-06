using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;
using ModernWebStore.Domain.Scopes;
using ModernWebStore.SharedKernel.Helpers;

namespace ModernWebStore.Tests.Domain.Scopes
{
    [TestClass]
    public class UserScopesTests
    {
        private User _validUser = new User("anrebaltieri@hotmail.com", "123456", true);
        private User _invalidPasswordUser = new User("andrebaltieri@hotmail.com", "", true);
        private User _invalidEmailUser = new User("", "123456", true);

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldRegisterUser()
        {            
            Assert.AreEqual(true, UserScopes.RegisterUserScopeIsValid(_validUser));
        }

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldNotRegisterUserWhenPasswordIsInvalid()
        {
            Assert.AreEqual(false, UserScopes.RegisterUserScopeIsValid(_invalidPasswordUser));
        }

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldNotRegisterUserWhenEmailIsInvalid()
        {
            Assert.AreEqual(false, UserScopes.RegisterUserScopeIsValid(_invalidEmailUser));
        }

        [TestMethod]
        [TestCategory("User Scopes - Authenticate")]
        public void ShouldAuthenticateUser()
        {
            var isValid = UserScopes.AuthenticateUserScopeIsValid(_validUser, "andrebaltieri@hotmail.com", StringHelper.Encrypt("123456"));
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        [TestCategory("User Scopes - Authenticate")]
        public void ShouldNotAuthenticateUser()
        {
            Assert.AreEqual(false, UserScopes.AuthenticateUserScopeIsValid(_validUser, "andrebaltieri@gmail.com", "123456"));
        }
    }
}
