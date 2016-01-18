﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Xunit;

namespace Core2D.UnitTests
{
    public class PropertyTests
    {
        [Fact]
        public void Inherits_From_ObservableObject()
        {
            var target = new Property();
            Assert.True(target is ObservableObject);
        }
        
        [Fact]
        public void ToString_Should_Return_Value_String()
        {
            var target = Property.Create(null, "Property1", "Value1");

            Assert.Equal("Value1", target.ToString());
        }
    }
}
