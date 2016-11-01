﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Reflection;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestSystemObject : ConsoleTest
    {
        [TestMethod]
        public void SystemObject_ToStringVraćaPunoImeKlase()
        {
            SystemObject.IspisToString();
            Assert.AreEqual("Vsite.CSharp.MojaKlasa", cw.GetString());
            Assert.AreEqual("Vsite.CSharp.MojaKlasa", cw.GetString());
            Assert.AreEqual("Vsite.CSharp.MojaKlasa", cw.GetString());
        }

        [TestMethod]
        public void SystemObject_GetTypeVraćaTipKlase()
        {
            SystemObject.IspisGetType();
            for (int i = 0; i < 3 ; ++i)
            {
                Type obj = cw.GetObject() as Type;
                Assert.IsNotNull(obj);
                Assert.AreEqual("MojaKlasa", obj.Name);
                Assert.AreEqual("Vsite.CSharp", obj.Namespace);
                Assert.AreEqual("System.Object", obj.BaseType.FullName);
                Assert.AreEqual(1, obj.GetConstructors().Length);
                Assert.AreEqual(4, obj.GetMethods().Length);
                var methodNames = obj.GetMethods().Select(mi => mi.Name);
                Assert.IsTrue(methodNames.Contains("ToString"));
                Assert.IsTrue(methodNames.Contains("GetType"));
                Assert.IsTrue(methodNames.Contains("GetHashCode"));
                Assert.IsTrue(methodNames.Contains("Equals"));
                Assert.AreEqual(0, obj.GetMethods(BindingFlags.Static).Count());
            }
        }

        [TestMethod]
        public void SystemObject_GetHashCodeVraćaCijeliBroj()
        {
            SystemObject.IspisGetHashCode();
            int hash1 = cw.GetInt();
            int hash2 = cw.GetInt();
            int hash3 = cw.GetInt();
            Assert.AreEqual(hash1, hash2);
            Assert.AreNotEqual(hash1, hash3);
        }

        [TestMethod]
        public void SystemObject_EqualsRadiUsporedbuPoReferenci()
        {
            SystemObject.IspisEquals();
            Assert.AreEqual(true, cw.GetBoolean());
            Assert.AreEqual(false, cw.GetBoolean());
            Assert.AreEqual(true, cw.GetBoolean());
            Assert.AreEqual(false, cw.GetBoolean());
            Assert.AreEqual(false, cw.GetBoolean());
            Assert.AreEqual(false, cw.GetBoolean());
        }
    }
}
