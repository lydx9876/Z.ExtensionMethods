// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_IsAssignableFrom
    {
        [TestMethod]
        public void IsAssignableFrom()
        {
            // Type
            var stringObject = (object) "FizzBuzz";

            // Exemples
            bool result1 = stringObject.IsAssignableFrom(typeof (string)); // return true;
            bool result2 = stringObject.IsAssignableFrom<string>(); // return true;
            bool result3 = stringObject.IsAssignableFrom<object>(); // return false;
            bool result4 = stringObject.IsAssignableFrom<int>(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
        }
    }
}